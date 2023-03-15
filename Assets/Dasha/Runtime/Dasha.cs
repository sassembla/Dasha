using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

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


        internal static void AddHook(string url, string hookedDataID, Action<byte[], object[]> onHooked)
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

        internal static void RemoveHook(string url)
        {
            @this.hookDict.TryRemove(url, out var t);
        }

        // hookIDに対応したファイルが存在するはずのパスを返す。
        // この関数自体をテストにも利用する。
        public static string GetDataPathFromDataID(string hookedDataID)
        {
            return Path.Combine(@this.DASHA_DATA_PATH, hookedDataID);
        }

        // TODO: この関数がconditionalになる。
        // 指定URLへのフックが存在している場合trueを返す
        internal static bool TryHasHook(string url)
        {
            if (!@this.hookDict.ContainsKey(url))
            {
                return false;
            }

            return true;
        }

        // TODO: この関数がconditionalになる。
        // 通信をurlをキーとして奪い、ダミーのレスポンスを返す。
        internal static bool TryPullHook(string url, params object[] inputs)
        {
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
        }

        // urlに対するデータを保存する。
        internal static void Save(string hookDataID, string url, int code, Dictionary<string, string> responseHeader, byte[] hookData)
        {
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
            Debug.Log("succeeded to write data for URL:" + url + " with hookDataID:" + hookDataID);
        }
    }
}
