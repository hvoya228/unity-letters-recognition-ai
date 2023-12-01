using System;
using System.Collections.Generic;
using UnityEngine;

public class NeuronsTrainer : MonoBehaviour
{
    private int[][] trainingData;
    private int[][] labels;
    private List<Neuron> neurons;

    public static bool isFinishedTraining = false;

    public static event Action<string, Color> OnTrainedNotification;
    public static event Action<string, Color> OnTrainingNotification;
    public static event Action<List<Neuron>> OnTrained;

    private void GenerateLabels()
    {
        labels = new int[trainingData.Length][];

        for (int i = 0; i < trainingData.Length; i++)
        {
            labels[i] = new int[trainingData.Length];

            for (int j = 0; j < trainingData.Length; j++)
            {
                labels[i][j] = 0;
            }

            labels[i][i] = 1;
        }
    }

    private void CreateNeurons()
    {
        neurons = new List<Neuron>();

        for (int i = 0; i < 26; i++)
        {
            neurons.Add(new Neuron(20));
        }
    }

    public void Train()
    {
        isFinishedTraining = false;

        trainingData = TrainingData.GetTrainingData();
        GenerateLabels();
        CreateNeurons();

        for (int i = 0; i < 26; i++)
        {
            OnTrainingNotification?.Invoke($"{i+1}/{26} neuron training...", Color.yellow);
            neurons[i].StartTraining(labels[i], trainingData);
        }

        OnTrained?.Invoke(neurons);
        OnTrainedNotification?.Invoke("Neurons are trained!", Color.green);

        isFinishedTraining = true;
    }
}
