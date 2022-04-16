using UnityEngine;
using UnityEngine.UI;

public class ResultScreen : MonoBehaviour
{
    [SerializeField] private Text _resultText;

    public void SetResultText(string result)
    {
        _resultText.text = result;
    }



}


