﻿using System;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject[] _sceneObjects;
    public Action OnMenuOpened;

    private void OnEnable()
    {
        SetObjectsActive(false);
        OnMenuOpened?.Invoke();
    }
    private void OnDisable()
    {
        SetObjectsActive(true);
    }

    private void SetObjectsActive(bool isActive)
    {
        for (int i = 0; i < _sceneObjects.Length; i++)
        {
            _sceneObjects[i].SetActive(isActive);
        }
    }

}
