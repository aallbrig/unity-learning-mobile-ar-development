using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace SceneSelection.Runtime.Tests.SceneSelection.Playmode.Tests
{
    public class SceneSelectionUIControllerBehavior
    {
        [UnityTest]
        public IEnumerator SceneSelectionControllerIsAComponent()
        {
            var go = new GameObject();
            var sut = go.AddComponent<SceneSelectionController>();
            yield return null;
            Assert.NotNull(sut);
        }
        [UnityTest]
        public IEnumerator SceneSelectionUIAcceptsListOfAddressables()
        {
            var go = new GameObject();
            var sut = go.AddComponent<SceneSelectionController>();
            yield return null;
            Assert.NotNull(sut);
        }
    }
}
