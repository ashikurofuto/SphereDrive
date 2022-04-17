using System;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject[] _sceneObjects;
    public Action OnMenuOpened;

    private void OnEnable()
    {
        OnMenuOpened?.Invoke();
    }



}
