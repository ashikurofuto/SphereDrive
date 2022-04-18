using System;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    public Action OnMenuOpened;

    private void OnEnable()
    {
        OnMenuOpened?.Invoke();
    }



}
