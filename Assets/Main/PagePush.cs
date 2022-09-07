using Demo.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Page;


public class PagePush : MonoBehaviour
{
    [SerializeField]PageContainer _pageContainer;

    private void Start()
    {
        //_pageContainer.Push(ResourceKey.TopPagePrefab(), false, loadAsync: false);
        var handle = _pageContainer.Push("Page1",true);
    }
}
