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
        private ConcurrentDictionary<string, byte[]> hookDict = new ConcurrentDictionary<string, byte[]>();

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


        internal static void AddHook(string url, string hookedDataID)
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

            @this.hookDict[url] = data;
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
        // 通信をurlをキーとして奪い、ダミーのレスポンスを返す。
        internal static bool TryPullHook(string url, params object[] inputs)
        {
            if (!@this.hookDict.ContainsKey(url))
            {
                return false;
            }

            // TODO: このインターフェースの畳み込みをユーザー側に押し付けたいところ。この情報も記録できるといいか。確かに。
            if (@this.hookDict.TryGetValue(url, out var data))
            {
                var successFunc = (Action<string, int, Dictionary<string, string>, byte[]>)inputs[0];
                successFunc(url, 200, new Dictionary<string, string>(), data);
                return true;
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