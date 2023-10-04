using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace SceneSelection.Runtime
{

    // This class interprets user interaction from a UI and loads in scenes upon request
    public class SceneSelectionController : MonoBehaviour
    {
        // the string is meant to be an error message
        public UnityEvent<string> operationError;
        public SceneManifest sceneManifest;
        private AssetReferenceScene _currentAssetRef;

        public void LoadSceneByIndex(int index)
        {
            if (index < 0 || index >= sceneManifest.scenes.Count)
            {
                HandleError($"Scene index {index} is out of range.");
                return;
            }

            var assetRef = sceneManifest.scenes[index];
            var loadSceneOperation = assetRef.LoadSceneAsync();
            loadSceneOperation.Completed += OnSceneLoaded;
        }

        private void OnSceneLoaded(AsyncOperationHandle<SceneInstance> sceneLoadOperation)
        {
            if (sceneLoadOperation.Status != AsyncOperationStatus.Succeeded)
            {
                HandleError($"Scene load operation failed {sceneLoadOperation.Status}");
                return;
            }

            var sceneInstance = sceneLoadOperation.Result;
            Debug.Log($"scene instance: {sceneInstance}");
        }

        private void HandleError(string errorMessage)
        {
            Debug.LogError(errorMessage);
            operationError?.Invoke(errorMessage);
        }
    }
}
