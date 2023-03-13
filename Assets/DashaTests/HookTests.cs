using System;
using System.Collections;
using AutoyaFramework;
using Miyamasu;

using DashaCore;
using System.IO;
using UnityEngine;

/**
	フック作成関連のテスト
*/
public class HookTests : MiyamasuTestRunner
{
    private const string url = "https://httpbin.org/get";
    private const string hookedDataID = "value for something";

    [MSetup]
    public IEnumerator Setup()
    {
        yield break;
    }

    [MTest]
    public IEnumerator SetHookToURL()
    {
        var passed = false;
        Dasha.PrepareHook(
            url,
            result =>
            {
                passed = true;
                return (false, null, null);
            }
        );

        var done = false;
        Autoya.Http_GetByBytes(
            url,
            (conId, result) =>
            {
                Debug.Log("result:" + result);
                done = true;
            },
            (conId, code, reason, status) =>
            {
                Fail("失敗するはずないが失敗してる code:" + code + " reason:" + reason);
                done = true;
            }
        );

        yield return WaitUntil(
            () => done,
            () => { throw new TimeoutException("too late"); }
        );

        True(passed, "not passed.");
    }

    [MTest]
    public IEnumerator SetHookToURLThenSaveResult()
    {
        var passed = false;
        Dasha.PrepareHook(
            url,
            result =>
            {
                passed = true;
                return (true, hookedDataID, result);
            }
        );

        var done = false;
        Autoya.Http_GetByBytes(
            url,
            (conId, result) =>
            {
                Debug.Log("result:" + result);
                done = true;
            },
            (conId, code, reason, status) =>
            {
                Fail("失敗するはずないが失敗してる code:" + code + " reason:" + reason);
                done = true;
            }
        );

        yield return WaitUntil(
            () => done,
            () => { throw new TimeoutException("too late"); }
        );

        True(passed, "not passed.");
        True(File.Exists(Dasha.GetDataPathFromDataID(hookedDataID)), "file not exists. missing:" + Dasha.GetDataPathFromDataID(hookedDataID));
    }

    /*
        dashaで生成したファイルを指定し、APIに対してダミーレスポンスを当てる。
    */
    [MTest]
    public IEnumerator UseHookToURL()
    {
        var path = Dasha.GetDataPathFromDataID(hookedDataID);
        var expected = File.ReadAllBytes(path);

        Dasha.AddHook(url, hookedDataID);

        var done = false;
        Autoya.Http_GetByBytes(
            url,
            (conId, result) =>
            {
                // バイト列の一致を見る
                for (var i = 0; i < result.Length; i++)
                {
                    True(result[i] == expected[i]);
                }

                done = true;
            },
            (conId, code, reason, status) =>
            {
                Fail("なぜか失敗している");
                done = true;
            }
        );

        yield return WaitUntil(
            () => done,
            () => { throw new TimeoutException("too late"); }
        );
    }

    [MTeardown]
    public IEnumerator Teardown()
    {
        yield break;
    }
}
