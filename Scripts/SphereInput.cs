using System;
using UnityEngine;

public class SphereInput : MonoBehaviour
{
    private Vector3 _direction;
    public Vector3 Direction { get => _direction;}
    public bool CanUseInput { get; set; }
    public Action OnMenuCalled;


    private void Update()
    {
        if (!CanUseInput)
            return;
        ReadInputs();
        MenuCall();
    }
    private void ReadInputs()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.y = 0;
        _direction.z = Input.GetAxis("Vertical");
    }
    private void MenuCall()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnMenuCalled?.Invoke();
            CanUseInput = false;
        }
    }

}
