using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StatusText : MonoBehaviour
{
    private Text statusText;

    private void Start()
    {
        statusText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        NeuronsTrainer.OnTrainedNotification += ShowStatus;
        NeuronsTrainer.OnTrainingNotification += ShowStatus;
        Recognizer.OnEmptyTrainedNeuronsListNotification += ShowStatus;
    }

    private void OnDisable()
    {
        NeuronsTrainer.OnTrainedNotification -= ShowStatus;
        NeuronsTrainer.OnTrainingNotification -= ShowStatus;
        Recognizer.OnEmptyTrainedNeuronsListNotification -= ShowStatus;
    }

    private void ShowStatus(string message, Color collor)
    {
        statusText.color = collor;
        statusText.text = message;
    }
}
