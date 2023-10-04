using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.TestTools;

namespace SceneSelection.Runtime.Tests.Playmode
{
    public class SceneSelectionButtonGroupUIBehavior
    {
        private readonly string _prefabAddress = "Scene Selection Button Group";
        private readonly Vector3 _spawnPoint = Vector3.zero;
        private readonly Quaternion _spawnRotation = Quaternion.identity;
        private AssetReferenceGameObject _sut;
        private AsyncOperationHandle<GameObject> _prefabLoadOperation;

        [UnityTest]
        public IEnumerator PrefabAvailableThroughAddressables()
        {
            _prefabLoadOperation = Addressables.InstantiateAsync(_prefabAddress, _spawnPoint, _spawnRotation);
            while (!_prefabLoadOperation.IsDone) yield return null;
            
            var sutInstance = _prefabLoadOperation.Result;
            
            Assert.IsNotNull(sutInstance);
        }
    }
}
