using UnityEngine;
using UnityEngine.UI;
using System;

public class ResultScreen : MonoBehaviour
{
    [SerializeField] private Text _resultText;

    public void SetResultText(string result)
    {
        _resultText.text = result;
    }



}


