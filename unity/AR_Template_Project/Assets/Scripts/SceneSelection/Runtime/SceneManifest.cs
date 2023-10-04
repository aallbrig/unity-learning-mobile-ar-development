using System.Collections.Generic;
using UnityEngine;

namespace SceneSelection.Runtime
{
    [CreateAssetMenu(fileName = "Scene Manifest", menuName = "Game/SceneSelection/new Scene Manifest", order = 0)]
    public class SceneManifest : ScriptableObject
    {
        public List<AssetReferenceScene> scenes = new List<AssetReferenceScene>();
    }
}
