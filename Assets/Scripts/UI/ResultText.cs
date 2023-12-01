using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    private Text resultText;

    private void Start()
    {
        resultText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        Recognizer.OnShowResult += ShowResult;
    }

    private void OnDisable()
    {
        Recognizer.OnShowResult -= ShowResult;
    }

    private void ShowResult(string result)
    {
        resultText.text = result;
    }
}
