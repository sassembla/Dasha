
using UnityEngine.TestTools;
using System;
using System.Collections;
public class AssetBundleListDownloaderTests_Miyamasu {
    [UnityTest] public IEnumerator GetAssetBundleList() {
        var rec = new Miyamasu.Recorder("AssetBundleListDownloaderTests", "GetAssetBundleList");
        var instance = new AssetBundleListDownloaderTests();
        instance.rec = rec;

        
        
        yield return instance.GetAssetBundleList();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator GetAssetBundleListFailed() {
        var rec = new Miyamasu.Recorder("AssetBundleListDownloaderTests", "GetAssetBundleListFailed");
        var instance = new AssetBundleListDownloaderTests();
        instance.rec = rec;

        
        
        yield return instance.GetAssetBundleListFailed();
        rec.MarkAsPassed();

        
    }
}
public class AssetBundleLoaderTests_Miyamasu {
    [UnityTest] public IEnumerator LoadAssetByAssetName() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadAssetByAssetName");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadAssetByAssetName();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadSameAssetByAssetName() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadSameAssetByAssetName");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSameAssetByAssetName();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadAssetWithDependency() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadAssetWithDependency");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadAssetWithDependency();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadSameAssetWithDependsOnOneAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadSameAssetWithDependsOnOneAssetBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSameAssetWithDependsOnOneAssetBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator Load2Assets_1isDependsOnAnother_DependedFirst() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "Load2Assets_1isDependsOnAnother_DependedFirst");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Load2Assets_1isDependsOnAnother_DependedFirst();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator Load2Assets_1isDependsOnAnother_DependingFirst() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "Load2Assets_1isDependsOnAnother_DependingFirst");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Load2Assets_1isDependsOnAnother_DependingFirst();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator Load2AssetsWhichDependsOnSameAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "Load2AssetsWhichDependsOnSameAssetBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Load2AssetsWhichDependsOnSameAssetBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator NestedDependency() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "NestedDependency");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.NestedDependency();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadCrcMismatchedBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadCrcMismatchedBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadCrcMismatchedBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadMissingBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadMissingBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadMissingBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadMissingDependentBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadMissingDependentBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadMissingDependentBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadBundleWithTimeout() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadBundleWithTimeout");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadBundleWithTimeout();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadAllAssetsOnce() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadAllAssetsOnce");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadAllAssetsOnce();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator OnMemoryBundleNames() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "OnMemoryBundleNames");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.OnMemoryBundleNames();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator OnMemoryAssetNames() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "OnMemoryAssetNames");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.OnMemoryAssetNames();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator UnloadAllAssetBundles() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "UnloadAllAssetBundles");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UnloadAllAssetBundles();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetContainedAssetBundleName() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "GetContainedAssetBundleName");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetContainedAssetBundleName();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator UnloadAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "UnloadAssetBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UnloadAssetBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator IsBundleCachedOnStorage() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "IsBundleCachedOnStorage");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.IsBundleCachedOnStorage();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator IsBundleCachedOnMemory() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "IsBundleCachedOnMemory");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.IsBundleCachedOnMemory();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator AssetBundleInfoFromAssetName() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "AssetBundleInfoFromAssetName");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AssetBundleInfoFromAssetName();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetAssetBundleSize() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "GetAssetBundleSize");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetAssetBundleSize();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetSameAssetBundleOnceThenFailToDownload() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "GetSameAssetBundleOnceThenFailToDownload");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetSameAssetBundleOnceThenFailToDownload();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator LoadSceneFromAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundleLoaderTests", "LoadSceneFromAssetBundle");
        var instance = new AssetBundleLoaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSceneFromAssetBundle();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class AssetBundlePreloaderTests_Miyamasu {
    [UnityTest] public IEnumerator GetPreloadList() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "GetPreloadList");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetPreloadList();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator PreloadWithCached_NoAdditionalDownload() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "PreloadWithCached_NoAdditionalDownload");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadWithCached_NoAdditionalDownload();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator PreloadWithCachedAndNotCached() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "PreloadWithCachedAndNotCached");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadWithCachedAndNotCached();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator Preload2AssetBundles() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "Preload2AssetBundles");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Preload2AssetBundles();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator PreloadWithPreloadList() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "PreloadWithPreloadList");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadWithPreloadList();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator ContinueGetPreloading() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "ContinueGetPreloading");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ContinueGetPreloading();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator DiscontinueGetPreloading() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "DiscontinueGetPreloading");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DiscontinueGetPreloading();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetPreloadingAssetBundleWeight() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "GetPreloadingAssetBundleWeight");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetPreloadingAssetBundleWeight();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetPreloadingAssetBundleNames() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "GetPreloadingAssetBundleNames");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetPreloadingAssetBundleNames();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetPreloadingAssetBundleNamesWithCache() {
        var rec = new Miyamasu.Recorder("AssetBundlePreloaderTests", "GetPreloadingAssetBundleNamesWithCache");
        var instance = new AssetBundlePreloaderTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetPreloadingAssetBundleNamesWithCache();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class AppUpdateTests_Miyamasu {
    [UnityTest] public IEnumerator ReceiveAppUpdate() {
        var rec = new Miyamasu.Recorder("AppUpdateTests", "ReceiveAppUpdate");
        var instance = new AppUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveAppUpdate();
        rec.MarkAsPassed();

        
    }
}
public class AssetBundlesImplementationTests_Miyamasu {
    [UnityTest] public IEnumerator GetAssetBundleListFromDebugMethod() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "GetAssetBundleListFromDebugMethod");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetAssetBundleListFromDebugMethod();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator GetAssetBundleList() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "GetAssetBundleList");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetAssetBundleList();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator GetAssetBundleListFailThenTryAgain() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "GetAssetBundleListFailThenTryAgain");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetAssetBundleListFailThenTryAgain();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator GetAssetBundleBeforeGetAssetBundleListBecomeFailed() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "GetAssetBundleBeforeGetAssetBundleListBecomeFailed");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetAssetBundleBeforeGetAssetBundleListBecomeFailed();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator GetAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "GetAssetBundle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetAssetBundle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAssetBundleBeforeGetAssetBundleListWillFail() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAssetBundleBeforeGetAssetBundleListWillFail");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAssetBundleBeforeGetAssetBundleListWillFail();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAssetBundle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAssetBundle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAssetBundles() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAssetBundles");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAssetBundles();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAssetBundleWithGeneratedPreloadList() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAssetBundleWithGeneratedPreloadList");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAssetBundleWithGeneratedPreloadList();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAssetBundlesWithGeneratedPreloadList() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAssetBundlesWithGeneratedPreloadList");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAssetBundlesWithGeneratedPreloadList();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator IsAssetExistInAssetBundleList() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "IsAssetExistInAssetBundleList");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.IsAssetExistInAssetBundleList();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator IsAssetBundleExistInAssetBundleList() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "IsAssetBundleExistInAssetBundleList");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.IsAssetBundleExistInAssetBundleList();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AssetBundle_CachedBundleNames() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "AssetBundle_CachedBundleNames");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AssetBundle_CachedBundleNames();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AssetBundle_CachedBundleNamesWillBeUpdated() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "AssetBundle_CachedBundleNamesWillBeUpdated");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AssetBundle_CachedBundleNamesWillBeUpdated();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AssetBundle_NotCachedBundleNames() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "AssetBundle_NotCachedBundleNames");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AssetBundle_NotCachedBundleNames();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AssetBundle_NotCachedBundleNamesInSomeAssetCached() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "AssetBundle_NotCachedBundleNamesInSomeAssetCached");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AssetBundle_NotCachedBundleNamesInSomeAssetCached();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UpdateListWithOnMemoryAssets() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "UpdateListWithOnMemoryAssets");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UpdateListWithOnMemoryAssets();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UpdateListWithOnMemoryAssetsThenReloadChangedAsset() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "UpdateListWithOnMemoryAssetsThenReloadChangedAsset");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UpdateListWithOnMemoryAssetsThenReloadChangedAsset();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UpdateListWithOnMemoryAssetsThenPreloadLoadedChangedAsset() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "UpdateListWithOnMemoryAssetsThenPreloadLoadedChangedAsset");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UpdateListWithOnMemoryAssetsThenPreloadLoadedChangedAsset();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UpdateListWithOnMemoryAssetsThenPreloadUnloadedChangedAsset() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "UpdateListWithOnMemoryAssetsThenPreloadUnloadedChangedAsset");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UpdateListWithOnMemoryAssetsThenPreloadUnloadedChangedAsset();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator DownloadSameBundleListAtOnce() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "DownloadSameBundleListAtOnce");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DownloadSameBundleListAtOnce();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator DownloadMultipleBundleListAtOnce() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "DownloadMultipleBundleListAtOnce");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DownloadMultipleBundleListAtOnce();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator DownloadedMultipleListsAreEnabled() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "DownloadedMultipleListsAreEnabled");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DownloadedMultipleListsAreEnabled();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UpdateMultipleListAtOnce() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "UpdateMultipleListAtOnce");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UpdateMultipleListAtOnce();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator DownloadAssetBundleListManually() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "DownloadAssetBundleListManually");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DownloadAssetBundleListManually();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator DownloadAssetBundleListManuallyWithoutPrepareWillFail() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "DownloadAssetBundleListManuallyWithoutPrepareWillFail");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DownloadAssetBundleListManuallyWithoutPrepareWillFail();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAndLoadSameAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAndLoadSameAssetBundle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAndLoadSameAssetBundle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAndLoadDependentAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAndLoadDependentAssetBundle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAndLoadDependentAssetBundle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAndLoadDependentAssetBundle_Rev() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAndLoadDependentAssetBundle_Rev");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAndLoadDependentAssetBundle_Rev();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator LoadAndPreloadDependentAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "LoadAndPreloadDependentAssetBundle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadAndPreloadDependentAssetBundle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator LoadAndPreloadDependentAssetBundle_Rev() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "LoadAndPreloadDependentAssetBundle_Rev");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadAndPreloadDependentAssetBundle_Rev();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAndLoadAllAssetBundle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAndLoadAllAssetBundle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAndLoadAllAssetBundle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadAndLoadAllAssetBundle_Rev() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadAndLoadAllAssetBundle_Rev");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadAndLoadAllAssetBundle_Rev();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator LoadSceneAdditive() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "LoadSceneAdditive");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSceneAdditive();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator LoadSceneAdditiveSync() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "LoadSceneAdditiveSync");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSceneAdditiveSync();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator LoadSceneSingle() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "LoadSceneSingle");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSceneSingle();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator LoadSceneSingleSync() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "LoadSceneSingleSync");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadSceneSingleSync();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator PreloadScene() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "PreloadScene");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PreloadScene();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator FactoryReset() {
        var rec = new Miyamasu.Recorder("AssetBundlesImplementationTests", "FactoryReset");
        var instance = new AssetBundlesImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.FactoryReset();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
}
public class AssetBundleListUpdateTests_Miyamasu {
    [UnityTest] public IEnumerator RemoveUnnecessaryStoredAssetBundleListOnBoot() {
        var rec = new Miyamasu.Recorder("AssetBundleListUpdateTests", "RemoveUnnecessaryStoredAssetBundleListOnBoot");
        var instance = new AssetBundleListUpdateTests();
        instance.rec = rec;

        
        
        yield return instance.RemoveUnnecessaryStoredAssetBundleListOnBoot();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator StoredAssetBundleListIsEmptyOnBoot() {
        var rec = new Miyamasu.Recorder("AssetBundleListUpdateTests", "StoredAssetBundleListIsEmptyOnBoot");
        var instance = new AssetBundleListUpdateTests();
        instance.rec = rec;

        
        
        yield return instance.StoredAssetBundleListIsEmptyOnBoot();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator StoredAssetBundleListIsNotEnoughOnBoot() {
        var rec = new Miyamasu.Recorder("AssetBundleListUpdateTests", "StoredAssetBundleListIsNotEnoughOnBoot");
        var instance = new AssetBundleListUpdateTests();
        instance.rec = rec;

        
        
        yield return instance.StoredAssetBundleListIsNotEnoughOnBoot();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator StoredAssetBundleListIsEnoughOnBoot() {
        var rec = new Miyamasu.Recorder("AssetBundleListUpdateTests", "StoredAssetBundleListIsEnoughOnBoot");
        var instance = new AssetBundleListUpdateTests();
        instance.rec = rec;

        
        
        yield return instance.StoredAssetBundleListIsEnoughOnBoot();
        rec.MarkAsPassed();

        
    }
}
public class AssetUpdateTests_Miyamasu {
    [UnityTest] public IEnumerator ReceiveFirstList() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveFirstList");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveFirstList();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator ReceiveListUpdated() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveListUpdated");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveListUpdated();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator ReceiveUpdatedListThenListWillBeUpdated() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveUpdatedListThenListWillBeUpdated");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveUpdatedListThenListWillBeUpdated();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator ReceiveUpdatedListThenOnAssetBundleListUpdatedFired() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveUpdatedListThenOnAssetBundleListUpdatedFired");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveUpdatedListThenOnAssetBundleListUpdatedFired();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator ReceiveUpdatedListThenIgnore() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveUpdatedListThenIgnore");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveUpdatedListThenIgnore();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator ReceiveUpdatedListThenIgnoreAndIgnoredListIsCached() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveUpdatedListThenIgnoreAndIgnoredListIsCached");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveUpdatedListThenIgnoreAndIgnoredListIsCached();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator ReceiveUpdatedListThenListWillBeUpdatedThenRestore() {
        var rec = new Miyamasu.Recorder("AssetUpdateTests", "ReceiveUpdatedListThenListWillBeUpdatedThenRestore");
        var instance = new AssetUpdateTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ReceiveUpdatedListThenListWillBeUpdatedThenRestore();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
}
public class AuthenticatedHTTPImplementationTests_Miyamasu {
    [UnityTest] public IEnumerator AutoyaHTTPGet() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPGet");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPGet();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPGetWithAdditionalHeader() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPGetWithAdditionalHeader");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPGetWithAdditionalHeader();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPGetFailWith404() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPGetFailWith404");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPGetFailWith404();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPGetFailWithUnauth() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPGetFailWithUnauth");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPGetFailWithUnauth();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPGetFailWithTimeout() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPGetFailWithTimeout");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPGetFailWithTimeout();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPPost() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPPost");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPPost();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPPostFailWith404() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPPostFailWith404");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPPostFailWith404();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPPostFailWithUnauth() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPPostFailWithUnauth");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPPostFailWithUnauth();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AutoyaHTTPPostFailWithTimeout() {
        var rec = new Miyamasu.Recorder("AuthenticatedHTTPImplementationTests", "AutoyaHTTPPostFailWithTimeout");
        var instance = new AuthenticatedHTTPImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AutoyaHTTPPostFailWithTimeout();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
}
public class AuthImplementationTests_Miyamasu {
    [UnityTest] public IEnumerator WaitDefaultAuthenticate() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "WaitDefaultAuthenticate");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.WaitDefaultAuthenticate();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator DeleteAllUserData() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "DeleteAllUserData");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DeleteAllUserData();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator HandleBootAuthFailed() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "HandleBootAuthFailed");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HandleBootAuthFailed();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator HandleBootAuthFailedThenAttemptAuthentication() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "HandleBootAuthFailedThenAttemptAuthentication");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HandleBootAuthFailedThenAttemptAuthentication();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator HandleLogoutThenAuthenticationAttemptSucceeded() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "HandleLogoutThenAuthenticationAttemptSucceeded");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HandleLogoutThenAuthenticationAttemptSucceeded();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator IntentionalLogout() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "IntentionalLogout");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.IntentionalLogout();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator HandleTokenRefreshFailed() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "HandleTokenRefreshFailed");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HandleTokenRefreshFailed();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator HandleTokenRefreshFailedThenAttemptAuthentication() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "HandleTokenRefreshFailedThenAttemptAuthentication");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HandleTokenRefreshFailedThenAttemptAuthentication();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator UnauthorizedThenHttpGet() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "UnauthorizedThenHttpGet");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UnauthorizedThenHttpGet();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator AvoidHttpAuthFailCascade() {
        var rec = new Miyamasu.Recorder("AuthImplementationTests", "AvoidHttpAuthFailCascade");
        var instance = new AuthImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AvoidHttpAuthFailCascade();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
}
public class EndPointImplementationRetryTests_Miyamasu {
    [UnityTest] public IEnumerator EndPointUpdateRetry() {
        var rec = new Miyamasu.Recorder("EndPointImplementationRetryTests", "EndPointUpdateRetry");
        var instance = new EndPointImplementationRetryTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.EndPointUpdateRetry();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class EndPointImplementationTests_Miyamasu {
    [UnityTest] public IEnumerator EndPointUpdateWithEmptyInfo() {
        var rec = new Miyamasu.Recorder("EndPointImplementationTests", "EndPointUpdateWithEmptyInfo");
        var instance = new EndPointImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.EndPointUpdateWithEmptyInfo();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator EndPointUpdate() {
        var rec = new Miyamasu.Recorder("EndPointImplementationTests", "EndPointUpdate");
        var instance = new EndPointImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.EndPointUpdate();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator EndPointUpdateSub() {
        var rec = new Miyamasu.Recorder("EndPointImplementationTests", "EndPointUpdateSub");
        var instance = new EndPointImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.EndPointUpdateSub();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class MaintenanceTests_Miyamasu {
    [UnityTest] public IEnumerator Maintenance() {
        var rec = new Miyamasu.Recorder("MaintenanceTests", "Maintenance");
        var instance = new MaintenanceTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Maintenance();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator SetOnMaintenance() {
        var rec = new Miyamasu.Recorder("MaintenanceTests", "SetOnMaintenance");
        var instance = new MaintenanceTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.SetOnMaintenance();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class IPTests_Miyamasu {
    [UnityTest] public IEnumerator GetLocalIPSync() {
        var rec = new Miyamasu.Recorder("IPTests", "GetLocalIPSync");
        var instance = new IPTests();
        instance.rec = rec;

        
        
        yield return instance.GetLocalIPSync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator GetLocalIP() {
        var rec = new Miyamasu.Recorder("IPTests", "GetLocalIP");
        var instance = new IPTests();
        instance.rec = rec;

        
        
        yield return instance.GetLocalIP();
        rec.MarkAsPassed();

        
    }
}
public class UdpTests_Miyamasu {
    [UnityTest] public IEnumerator SetReceiverThenSend() {
        var rec = new Miyamasu.Recorder("UdpTests", "SetReceiverThenSend");
        var instance = new UdpTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.SetReceiverThenSend();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator SetReceiverThenSendTwice() {
        var rec = new Miyamasu.Recorder("UdpTests", "SetReceiverThenSendTwice");
        var instance = new UdpTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.SetReceiverThenSendTwice();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator SetReceiverThenSendManyTimes() {
        var rec = new Miyamasu.Recorder("UdpTests", "SetReceiverThenSendManyTimes");
        var instance = new UdpTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.SetReceiverThenSendManyTimes();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
    [UnityTest] public IEnumerator SetReceiverThenSendManyTimesWithValidation() {
        var rec = new Miyamasu.Recorder("UdpTests", "SetReceiverThenSendManyTimesWithValidation");
        var instance = new UdpTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.SetReceiverThenSendManyTimesWithValidation();
        rec.MarkAsPassed();

        
        yield return instance.Teardown();
    }
}
public class EncryptTests_Miyamasu {
    [UnityTest] public IEnumerator AESEncrypt() {
        var rec = new Miyamasu.Recorder("EncryptTests", "AESEncrypt");
        var instance = new EncryptTests();
        instance.rec = rec;

        
        
        instance.AESEncrypt(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator AESEncryptLong() {
        var rec = new Miyamasu.Recorder("EncryptTests", "AESEncryptLong");
        var instance = new EncryptTests();
        instance.rec = rec;

        
        
        instance.AESEncryptLong(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator AESEncryptBytes() {
        var rec = new Miyamasu.Recorder("EncryptTests", "AESEncryptBytes");
        var instance = new EncryptTests();
        instance.rec = rec;

        
        
        instance.AESEncryptBytes(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Sha256Hash() {
        var rec = new Miyamasu.Recorder("EncryptTests", "Sha256Hash");
        var instance = new EncryptTests();
        instance.rec = rec;

        
        
        instance.Sha256Hash(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Sha512Hash() {
        var rec = new Miyamasu.Recorder("EncryptTests", "Sha512Hash");
        var instance = new EncryptTests();
        instance.rec = rec;

        
        
        instance.Sha512Hash(); yield return null;
        rec.MarkAsPassed();

        
    }
}
public class ManifestTests_Miyamasu {
    [UnityTest] public IEnumerator GetManifest() {
        var rec = new Miyamasu.Recorder("ManifestTests", "GetManifest");
        var instance = new ManifestTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.GetManifest();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator UpdateRuntimeManifest() {
        var rec = new Miyamasu.Recorder("ManifestTests", "UpdateRuntimeManifest");
        var instance = new ManifestTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.UpdateRuntimeManifest();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator StoredHasOldABList() {
        var rec = new Miyamasu.Recorder("ManifestTests", "StoredHasOldABList");
        var instance = new ManifestTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.StoredHasOldABList();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator StoredDoesNotHaveRequiredABList() {
        var rec = new Miyamasu.Recorder("ManifestTests", "StoredDoesNotHaveRequiredABList");
        var instance = new ManifestTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.StoredDoesNotHaveRequiredABList();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator UpdatedHasStoredList() {
        var rec = new Miyamasu.Recorder("ManifestTests", "UpdatedHasStoredList");
        var instance = new ManifestTests();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        yield return instance.UpdatedHasStoredList();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class NotificationTest_Miyamasu {
    [UnityTest] public IEnumerator GetStoredURLSchemeOnBoot() {
        var rec = new Miyamasu.Recorder("NotificationTest", "GetStoredURLSchemeOnBoot");
        var instance = new NotificationTest();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        instance.GetStoredURLSchemeOnBoot(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator GetStoredURLSchemeAfterBooted() {
        var rec = new Miyamasu.Recorder("NotificationTest", "GetStoredURLSchemeAfterBooted");
        var instance = new NotificationTest();
        instance.rec = rec;

        
        try {
            instance.Setup();
        } catch (Exception e) {
            rec.SetupFailed(e);
            throw;
        }
        
        instance.GetStoredURLSchemeAfterBooted(); yield return null;
        rec.MarkAsPassed();

        
    }
}
public class CacheHitImplementationTest_Miyamasu {
    [UnityTest] public IEnumerator Cache() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "Cache");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Cache();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheThenUpdateCache() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheThenUpdateCache");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheThenUpdateCache();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheThenHit() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheThenHit");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheThenHit();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheThenNotHitByNotCachedItem() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheThenNotHitByNotCachedItem");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheThenNotHitByNotCachedItem();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator HitWithCached() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "HitWithCached");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HitWithCached();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator HitWithCachedButNotExist() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "HitWithCachedButNotExist");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HitWithCachedButNotExist();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheMultipleSameInitial() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheMultipleSameInitial");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheMultipleSameInitial();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheThenUpdateCacheMultipleSameInitial() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheThenUpdateCacheMultipleSameInitial");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheThenUpdateCacheMultipleSameInitial();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheThenHitMultipleSameInitial() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheThenHitMultipleSameInitial");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheThenHitMultipleSameInitial();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CacheThenNotHitByNotCachedItemMultipleSameInitial() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "CacheThenNotHitByNotCachedItemMultipleSameInitial");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CacheThenNotHitByNotCachedItemMultipleSameInitial();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator HitWithCachedMultipleSameInitial() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "HitWithCachedMultipleSameInitial");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HitWithCachedMultipleSameInitial();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator HitWithCachedButNotExistMultipleSameInitial() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest", "HitWithCachedButNotExistMultipleSameInitial");
        var instance = new CacheHitImplementationTest();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.HitWithCachedButNotExistMultipleSameInitial();
        rec.MarkAsPassed();

        
    }
}
public class CacheHitImplementationTest_UpdateCache_Miyamasu {
    [UnityTest] public IEnumerator Cache() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_UpdateCache", "Cache");
        var instance = new CacheHitImplementationTest_UpdateCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Cache();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator InitialRemoved() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_UpdateCache", "InitialRemoved");
        var instance = new CacheHitImplementationTest_UpdateCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.InitialRemoved();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator InitialAdded() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_UpdateCache", "InitialAdded");
        var instance = new CacheHitImplementationTest_UpdateCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.InitialAdded();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator SameInitialCache() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_UpdateCache", "SameInitialCache");
        var instance = new CacheHitImplementationTest_UpdateCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.SameInitialCache();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator ContentRemoved() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_UpdateCache", "ContentRemoved");
        var instance = new CacheHitImplementationTest_UpdateCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ContentRemoved();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator ContentAdded() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_UpdateCache", "ContentAdded");
        var instance = new CacheHitImplementationTest_UpdateCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ContentAdded();
        rec.MarkAsPassed();

        
    }
}
public class CacheHitImplementationTest_MassCache_Miyamasu {
    [UnityTest] public IEnumerator MassCache() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_MassCache", "MassCache");
        var instance = new CacheHitImplementationTest_MassCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.MassCache();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator MassCacheHit() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_MassCache", "MassCacheHit");
        var instance = new CacheHitImplementationTest_MassCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.MassCacheHit();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator MassCacheNotHit() {
        var rec = new Miyamasu.Recorder("CacheHitImplementationTest_MassCache", "MassCacheNotHit");
        var instance = new CacheHitImplementationTest_MassCache();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.MassCacheNotHit();
        rec.MarkAsPassed();

        
    }
}
public class FilePersistImplementationTests_Miyamasu {
    [UnityTest] public IEnumerator IsNeverExists() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "IsNeverExists");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        instance.IsNeverExists(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator IsMustBeExist() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "IsMustBeExist");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        instance.IsMustBeExist(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Update() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "Update");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Update();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Append() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "Append");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Append();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Load() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "Load");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Load();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator LoadFail() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "LoadFail");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadFail();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Delete() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "Delete");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Delete();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator DeleteByDomain() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "DeleteByDomain");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DeleteByDomain();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator DeleteNonExist() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "DeleteNonExist");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DeleteNonExist();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator FileNamesInDomain() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "FileNamesInDomain");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.FileNamesInDomain();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator EmptyFileNamesInDomain() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "EmptyFileNamesInDomain");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.EmptyFileNamesInDomain();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator CreateFileThenDeleteFileThenFileNamesInDomain() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "CreateFileThenDeleteFileThenFileNamesInDomain");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CreateFileThenDeleteFileThenFileNamesInDomain();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator UpdateAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "UpdateAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UpdateAsync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator AppendAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "AppendAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.AppendAsync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator LoadAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "LoadAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadAsync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator LoadFailAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "LoadFailAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadFailAsync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator DeleteAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "DeleteAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DeleteAsync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator DeleteByDomainAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "DeleteByDomainAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DeleteByDomainAsync();
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator DeleteNonExistAsync() {
        var rec = new Miyamasu.Recorder("FilePersistImplementationTests", "DeleteNonExistAsync");
        var instance = new FilePersistImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.DeleteNonExistAsync();
        rec.MarkAsPassed();

        
    }
}
public class URLCachingImplementationTests_Miyamasu {
    [UnityTest] public IEnumerator LoadExample() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "LoadExample");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.LoadExample();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetSameSprite() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "GetSameSprite");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetSameSprite();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator GetUpdatedSprite() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "GetUpdatedSprite");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.GetUpdatedSprite();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator PurgeThenGetNew() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "PurgeThenGetNew");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PurgeThenGetNew();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator PurgeByDomainThenGetNew() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "PurgeByDomainThenGetNew");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.PurgeByDomainThenGetNew();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator SameURLMultiTimes() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "SameURLMultiTimes");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.SameURLMultiTimes();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator NotExistURLOnce() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "NotExistURLOnce");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.NotExistURLOnce();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator NotExistURLMultiTimes() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "NotExistURLMultiTimes");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.NotExistURLMultiTimes();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator CachingWithKey() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "CachingWithKey");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CachingWithKey();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator CachingWithKeyOtherURL() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "CachingWithKeyOtherURL");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.CachingWithKeyOtherURL();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator Timeout() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "Timeout");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Timeout();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator TimeoutWithKey() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "TimeoutWithKey");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.TimeoutWithKey();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator ExecuteExpiration() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "ExecuteExpiration");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ExecuteExpiration();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator ExecuteExpirationForManyFiles() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "ExecuteExpirationForManyFiles");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.ExecuteExpirationForManyFiles();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator Unload() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "Unload");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.Unload();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
    [UnityTest] public IEnumerator UnloadByDomain() {
        var rec = new Miyamasu.Recorder("URLCachingImplementationTests", "UnloadByDomain");
        var instance = new URLCachingImplementationTests();
        instance.rec = rec;

        
        yield return instance.Setup();
        
        yield return instance.UnloadByDomain();
        rec.MarkAsPassed();

        
        try {
            instance.Teardown();
        } catch (Exception e) {
            rec.TeardownFailed(e);
            throw;
        }
    }
}
public class JWTTests_Miyamasu {
    [UnityTest] public IEnumerator Read() {
        var rec = new Miyamasu.Recorder("JWTTests", "Read");
        var instance = new JWTTests();
        instance.rec = rec;

        
        
        instance.Read(); yield return null;
        rec.MarkAsPassed();

        
    }
    [UnityTest] public IEnumerator Create() {
        var rec = new Miyamasu.Recorder("JWTTests", "Create");
        var instance = new JWTTests();
        instance.rec = rec;

        
        
        instance.Create(); yield return null;
        rec.MarkAsPassed();

        
    }
}
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
}