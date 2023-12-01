using System;
using System.Collections.Generic;
using UnityEngine;

public class Recognizer : MonoBehaviour
{
    [SerializeField] List<Cell> cells;

    private int[] inputData;
    private List<Neuron> trainedNeurons;
    private List<double> resultsInPercents;

    public static event Action<string, Color> OnEmptyTrainedNeuronsListNotification;
    public static event Action<string> OnShowResult;

    private void OnEnable()
    {
        NeuronsTrainer.OnTrained += GetTrainedNeurons;
    }

    private void OnDisable()
    {
        NeuronsTrainer.OnTrained -= GetTrainedNeurons;
    }

    private void SetInputData()
    {
        inputData = new int[cells.Count];

        if (cells != null)
        {
            for (int i = 0; i < inputData.Length; i++)
            {
                inputData[i] = cells[i].GetInputData();
            }
        }
        else
        {
            Debug.LogWarning("Recognizer.cs: cells list is empty!");
        }
    }

    private void GetTrainedNeurons(List<Neuron> trainedNeurons)
    {
        this.trainedNeurons = trainedNeurons;
    }

    private void ProcessResults()
    {
        SetInputData();
        resultsInPercents = new List<double>();

        if (trainedNeurons != null)
        {
            for (int i = 0; i < trainedNeurons.Count; i++)
            {
                resultsInPercents.Add(trainedNeurons[i].ProcessInputs(inputData));
            }
        }
        else
        {
            OnEmptyTrainedNeuronsListNotification?.Invoke("List, of trained neurons, is empty!", Color.red);
        }
    }

    private string GetResult()
    {
        char[] resultsDescribing = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                                      'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                                      'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
                                      'Y', 'Z' };

        string trueResult = string.Empty;
        string possibleResult = string.Empty;

        for (int i = 0; i < resultsInPercents.Count; i++)
        {
            if (resultsInPercents[i] >= 1d)
            {
                trueResult = $"It`s 100% that it`s {resultsDescribing[i]}";
            }
            else if (resultsInPercents[i] >= 0.9d && resultsInPercents[i] < 1d)
            {
                trueResult = $"It`s {resultsInPercents[i]*100:00}% that it`s {resultsDescribing[i]}";
            }
            else if (resultsInPercents[i] >= 0.1d && resultsInPercents[i] < 0.9d)
            {
                possibleResult += $", maybe it`s {resultsDescribing[i]} ({resultsInPercents[i]*100:00}%)";
            }
        }

        if (trueResult == string.Empty)
        {
            trueResult = "I can`t provide a true result";
        }

        return trueResult + possibleResult;
    }

    public void Recognize()
    {
        ProcessResults();
        string result = GetResult();
        OnShowResult?.Invoke(result);
    }
}