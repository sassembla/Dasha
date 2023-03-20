using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using Logger = UnityEngine;
using System.Diagnostics;

/*
    USE_DUMMY_RESPONSE_DASHA scriptable define symbols required when use.
*/
namespace DashaCore
{
    public class Dasha
    {
        private string DASHA_DATA_PATH;
        private static Dasha @this;
        private ConcurrentDictionary<string, Action<object[]>> hookDict = new ConcurrentDictionary<string, Action<object[]>>();

        static Dasha()
        {
            // 一度だけ発生すればいい初期化処理
            @this = new Dasha();
#if UNITY_EDITOR
            // 初期値を使用する。Assetsフォルダの横に出る。
            @this.DASHA_DATA_PATH = "./DashaDataPool";
#else
            // 実機用の保存領域を使用する。
            @this.DASHA_DATA_PATH = Path.Combine(Application.persistentDataPath, "DashaDataPool");
#endif
        }

        [Conditional("USE_DUMMY_RESPONSE_DASHA")]
        public static void AddHook(string url, string hookedDataID, Action<byte[], object[]> onHooked)
        {
            byte[] data = null;
            var path = GetDataPathFromDataID(hookedDataID);

            using (var mem = new MemoryStream())
            using (var sr = new StreamReader(path))
            {
                sr.BaseStream.CopyTo(mem);
                data = mem.ToArray();
            }

            if (data == null)
            {
                throw new Exception("no data found, hookedDataID:" + hookedDataID + " is not exists in:" + path);
            }

            @this.hookDict[url] = (object[] parameters) => { onHooked(data, parameters); };
        }

        [Conditional("USE_DUMMY_RESPONSE_DASHA")]
        public static void RemoveHook(string url)
        {
            @this.hookDict.TryRemove(url, out var t);
        }

        // hookIDに対応したファイルが存在するはずのパスを返す。
        // この関数自体をテストにも利用する。
        public static string GetDataPathFromDataID(string hookedDataID)
        {
            return Path.Combine(@this.DASHA_DATA_PATH, hookedDataID);
        }

        // urlに対するデータを保存する。
        [Conditional("USE_DUMMY_RESPONSE_DASHA")]
        public static void Save(string url, string hookDataID, int code, Dictionary<string, string> responseHeader, byte[] hookData)
        {
#if TestHookForDasha
            if (hookDataID.Contains("/"))
            {
                throw new Exception("hookDataID should not contain / , because this will become filename for hookDataFile.");
            }
#else
            Logger.Debug.Assert(!hookDataID.Contains("/"), "hookDataID should not contain / , because this will become filename for hookDataFile.");
#endif

            if (!Directory.Exists(@this.DASHA_DATA_PATH))
            {
                Directory.CreateDirectory(@this.DASHA_DATA_PATH);
            }

            var targetDataPath = GetDataPathFromDataID(hookDataID);

            // TODO: 現在はidによってのみデータをidentifyしている。urlに対してフィルタできるようにすると、人が用意したやつを使える。responseHeaderとcodeも入れると良さそうではある。
            using (var sw = new StreamWriter(targetDataPath))
            {
                sw.BaseStream.Write(hookData, 0, hookData.Length);
            }
            Logger.Debug.Log("succeeded to write data for URL:" + url + " with hookDataID:" + hookDataID);
        }


        // ここから先はAPIに対して仕掛けるフック実装

        // 指定URLへのフックが存在している場合trueを返す
        public static bool TryHasHook(string url)
        {
#if USE_DUMMY_RESPONSE_DASHA
            if (!@this.hookDict.ContainsKey(url))
            {
                return false;
            }

            return true;
#else
            return false;
#endif
        }

        // 通信をurlをキーとして扱い、ダミーのレスポンスを返す。
        public static bool TryPullHook(string url, params object[] inputs)
        {
#if USE_DUMMY_RESPONSE_DASHA
            if (TryHasHook(url))
            {
                if (@this.hookDict.TryGetValue(url, out var onHooked))
                {
                    // 畳み込んで実行。
                    onHooked(inputs);
                    return true;
                }
            }

            return false;
#else
            return false;
#endif
        }
    }
}
