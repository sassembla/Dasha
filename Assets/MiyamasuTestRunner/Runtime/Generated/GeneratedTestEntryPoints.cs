
using UnityEngine.TestTools;
using System;
using System.Collections;
public class HookTests_Miyamasu {
    [UnityTest] public IEnumerator UseHookToURL() {
        var rec = new Miyamasu.Recorder("HookTests", "UseHookToURL");
        var instance = new HookTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UseHookToURL();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UseHookThenRemove() {
        var rec = new Miyamasu.Recorder("HookTests", "UseHookThenRemove");
        var instance = new HookTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UseHookThenRemove();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator SaveDataThenAddHook() {
        var rec = new Miyamasu.Recorder("HookTests", "SaveDataThenAddHook");
        var instance = new HookTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.SaveDataThenAddHook();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator SaveDataThenAddHookThenRemove() {
        var rec = new Miyamasu.Recorder("HookTests", "SaveDataThenAddHookThenRemove");
        var instance = new HookTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.SaveDataThenAddHookThenRemove();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator CaptureResultThenHook() {
        var rec = new Miyamasu.Recorder("HookTests", "CaptureResultThenHook");
        var instance = new HookTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CaptureResultThenHook();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator HookDataIDShouldNotContainsSlash() {
        var rec = new Miyamasu.Recorder("HookTests", "HookDataIDShouldNotContainsSlash");
        var instance = new HookTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        instance.HookDataIDShouldNotContainsSlash(); yield return null;
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
}