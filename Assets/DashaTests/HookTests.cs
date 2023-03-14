using System;
using System.Collections;
using AutoyaFramework;
using Miyamasu;

using DashaCore;
using System.IO;
using UnityEngine;
using System.Text;

/**
	フック作成関連のテスト

    Save
        特定レスポンスを保存する。
    
    Hook
        特定レスポンスを詰める。
*/
public class HookTests : MiyamasuTestRunner
{
    private const string url = "https://httpbin.org/get";
    private const string hookedDataID = "id for httpbin get";

    [MSetup]
    public IEnumerator Setup()
    {
        yield break;
    }

    [MTeardown]
    public IEnumerator Teardown()
    {
        yield break;
    }

    [MTest]
    public IEnumerator SetHookToURL()
    {
        var passed = false;
        // キャプチャする、これ自体は独自の点で必要だけど、通信がどうこうなら単に保存すればいいだけな気がするので、hookな形をとる必要がない。
        Dasha.Capture(
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
        Dasha.Capture(
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

    [MTest]
    public IEnumerator UseHookThenRemove()
    {
        var path = Dasha.GetDataPathFromDataID(hookedDataID);
        var expected = File.ReadAllBytes(path);

        Dasha.AddHook(url, hookedDataID);
        {
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

        Dasha.RemoveHook(url);
        {
            var removed = false;
            var done = false;
            Autoya.Http_GetByBytes(
                url,
                (conId, result) =>
                {
                    done = true;

                    // バイト列の一致を見る
                    for (var i = 0; i < result.Length; i++)
                    {
                        if (result[i] != expected[i])
                        {
                            removed = true;
                            return;
                        }
                    }
                },
                (conId, code, reason, status) =>
                {
                    Fail("なぜか失敗している");
                    done = true;
                }
            );

            yield return WaitUntil(
                () => done && removed,
                () => { throw new TimeoutException("too late, removed:" + removed + " done:" + done); }
            );
        }
    }


    [MTest]
    public IEnumerator SaveDataThenAddHook()
    {
        var expected = Encoding.UTF8.GetBytes(DateTime.UtcNow.ToString());

        // 適当なデータを保存し、その後hookをセット、対応する通信を実行して、結果が書きかわっていることを確認する。
        Dasha.Save(
            hookedDataID,
            url,
            200,
            null,
            expected
        );

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
                Fail("失敗するはずないが失敗してる code:" + code + " reason:" + reason);
                done = true;
            }
        );

        yield return WaitUntil(
            () => done,
            () => { throw new TimeoutException("too late"); }
        );
    }

    [MTest]
    public IEnumerator SaveDataThenAddHookThenRemove()
    {
        var expected = Encoding.UTF8.GetBytes(DateTime.UtcNow.ToString());

        // 適当なデータを保存し、その後hookをセット、対応する通信を実行して、結果が書きかわっていることを確認する。
        Dasha.Save(
            hookedDataID,
            url,
            200,
            null,
            expected
        );

        Dasha.AddHook(url, hookedDataID);
        {
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
                    Fail("失敗するはずないが失敗してる code:" + code + " reason:" + reason);
                    done = true;
                }
            );

            yield return WaitUntil(
                () => done,
                () => { throw new TimeoutException("too late"); }
            );
        }

        Dasha.RemoveHook(url);
        // removeしたあとは通信を行なってもヒットしないはず。
        {
            var removed = false;
            var done = false;
            Autoya.Http_GetByBytes(
                url,
                (conId, result) =>
                {
                    done = true;

                    // バイト列の一致を見る
                    for (var i = 0; i < result.Length; i++)
                    {
                        if (result[i] != expected[i])
                        {
                            removed = true;
                            return;
                        }
                    }
                },
                (conId, code, reason, status) =>
                {
                    Fail("失敗するはずないが失敗してる code:" + code + " reason:" + reason);
                    done = true;
                }
            );

            yield return WaitUntil(
                () => done && removed,
                () => { throw new TimeoutException("too late, removed:" + removed + " done:" + done); }
            );
        }
    }
}
