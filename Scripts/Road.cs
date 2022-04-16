using System;
using UnityEngine;

public class Road : MonoBehaviour
{
    public Action OnGameLosing;

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<Sphere>())
        {
            OnGameLosing?.Invoke();
        }
    }
}
