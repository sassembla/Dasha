using System;
using System.Collections;
using AutoyaFramework;
using Miyamasu;

using DashaCore;
using System.IO;
using UnityEngine;
using System.Text;
using System.Collections.Generic;

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

    /*
        dashaで生成したファイルを指定し、APIに対してダミーレスポンスを当てる。
    */
    [MTest]
    public IEnumerator UseHookToURL()
    {
        var path = Dasha.GetDataPathFromDataID(hookedDataID);
        var expected = File.ReadAllBytes(path);

        Dasha.AddHook(
            url,
            hookedDataID,
            (data, handles) =>
            {
                var successFunc = (Action<string, int, Dictionary<string, string>, byte[]>)handles[0];
                successFunc(url, 200, new Dictionary<string, string>(), data);
            }
        );

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

        Dasha.AddHook(
            url,
            hookedDataID,
            (data, handles) =>
            {
                var successFunc = (Action<string, int, Dictionary<string, string>, byte[]>)handles[0];
                successFunc(url, 200, new Dictionary<string, string>(), data);
            }
        );
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

        Dasha.AddHook(
            url,
            hookedDataID,
            (data, handles) =>
            {
                var successFunc = (Action<string, int, Dictionary<string, string>, byte[]>)handles[0];
                successFunc(url, 200, new Dictionary<string, string>(), data);
            }
        );

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

        Dasha.AddHook(
            url,
            hookedDataID,
            (data, handles) =>
            {
                var successFunc = (Action<string, int, Dictionary<string, string>, byte[]>)handles[0];
                successFunc(url, 200, new Dictionary<string, string>(), data);
            }
        );
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

    // 適当に通信し、結果を得て、それを保存し、hookとして利用する。
    [MTest]
    public IEnumerator CaptureResultThenHook()
    {
        byte[] expected = null;
        {
            var done = false;
            Autoya.Http_GetByBytes(
                url,
                (conId, result) =>
                {
                    // レスポンスを保存(この時点で編集したものを保存するとかすると用意として楽)
                    Dasha.Save(hookedDataID, url, 200, null, result);
                    expected = result;
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

        Dasha.AddHook(
            url,
            hookedDataID,
            (data, handles) =>
            {
                var successFunc = (Action<string, int, Dictionary<string, string>, byte[]>)handles[0];
                successFunc(url, 200, new Dictionary<string, string>(), data);
            }
        );

        // hook後の通信
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
    }
}
