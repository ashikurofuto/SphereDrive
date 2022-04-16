using System;
using System.Collections;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public Action OnGameWin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Sphere>())
        {
            StartCoroutine(FinishRoutine());
        }
    }

    private IEnumerator FinishRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        OnGameWin?.Invoke();
        
    }

}
