using System;
using UnityEngine.AddressableAssets;

namespace SceneSelection.Runtime
{
    // Thanks to
    // https://github.com/marc-antoine-girard/Unity3D-RuntimeScene/blob/main/Runtime/AssetReferenceScene.cs
#if UNITY_EDITOR
    using UnityEditor;

    [Serializable]
    public class AssetReferenceScene : AssetReferenceT<SceneAsset>
    {
        public AssetReferenceScene(string guid) : base(guid) { }
    }
#else
    [Serializable]
    public class AssetReferenceScene : AssetReference
    {
        public AssetReferenceScene(string guid) : base(guid) {}
    }
#endif
}
