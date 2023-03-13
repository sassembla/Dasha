using System;
using System.Collections;
using AutoyaFramework;
using Miyamasu;


/**
	フック作成関連のテスト
*/
public class HookTests : MiyamasuTestRunner
{
    [MSetup]
    public IEnumerator Setup()
    {
        yield break;
    }

    [MTest]
    public IEnumerator SetHookToURL()
    {
        var url = "https://somewhere/somthing";

        var passed = false;
        Dasha.Core.Dasha.AddHook(
            url,
            result =>
            {
                passed = true;
                return (false, string.Empty);
            }
        );

        var done = false;
        Autoya.Http_Get(
            url,
            (conId, result) =>
            {
                done = true;
            },
            (conId, code, reason, status) =>
            {
                done = true;
            }
        );

        yield return WaitUntil(
            () => done,
            () => { throw new TimeoutException("too late"); }
        );

        True(passed, "not passed.");
    }

    [MTeardown]
    public IEnumerator Teardown()
    {
        yield break;
    }
}
