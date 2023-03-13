using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace DashaCore
{
    public class Dasha
    {
        private const string DASHA_DATA_PATH = "./DashaDataPool";
        private static Dasha @this;
        private ConcurrentDictionary<string, Func<byte[], (bool, string, byte[])>> preHookDict = new ConcurrentDictionary<string, Func<byte[], (bool, string, byte[])>>();
        private ConcurrentDictionary<string, byte[]> hookDict = new ConcurrentDictionary<string, byte[]>();

        static Dasha()
        {
            // 一度だけ発生すればいい初期化処理
            @this = new Dasha();
        }

        public static void PrepareHook(string url, Func<byte[], (bool, string, byte[])> onHooked)
        {
            @this.preHookDict[url] = onHooked;
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
            @this.preHookDict.TryRemove(url, out var s);
            @this.hookDict.TryRemove(url, out var t);
        }

        // hookIDに対応したファイルが存在するはずのパスを返す。
        // この関数自体をテストにも利用する。
        public static string GetDataPathFromDataID(string hookedDataID)
        {
            return Path.Combine(DASHA_DATA_PATH, hookedDataID);
        }


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

        /*
            URLに対してのレスポンスをスキャンする。これはデータの採集を目的としている。
        */
        internal static void Scan(string url, byte[] data)
        {
            if (!@this.preHookDict.ContainsKey(url))
            {
                return;
            }

            if (@this.preHookDict.TryGetValue(url, out var onPrepareHook))
            {
                var prepareHookRequest = onPrepareHook(data);
                var shouldSave = prepareHookRequest.Item1;
                if (!shouldSave)
                {
                    return;
                }

                var hookID = prepareHookRequest.Item2;
                var hookData = prepareHookRequest.Item3;
                var targetDataPath = GetDataPathFromDataID(hookID);
                if (!Directory.Exists(DASHA_DATA_PATH))
                {
                    Directory.CreateDirectory(DASHA_DATA_PATH);
                }

                using (var sw = new StreamWriter(targetDataPath))
                {
                    sw.BaseStream.Write(hookData, 0, hookData.Length);
                }
                Debug.Log("succeeded to write data for URL:" + url + " with dataID:" + hookID);
            }
        }
    }
}