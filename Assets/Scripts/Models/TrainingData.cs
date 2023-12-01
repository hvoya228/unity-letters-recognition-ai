using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TrainingData
{
    private static int[][] trainingData = new int[][]
        {
            new int[] { 0, 1, 1, 0,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for A

            new int[] { 1, 1, 1, 0,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for B

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 1, 1, 1 }, // matrix for C

            new int[] { 1, 1, 1, 0,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 0 }, // matrix for D

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 1, 1, 1 }, // matrix for E

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 0, 0 }, // matrix for F

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for G

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for H

            new int[] { 1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0 }, // matrix for I

            new int[] { 0, 0, 0, 1,
                        0, 0, 0, 1,
                        0, 0, 0, 1,
                        0, 1, 0, 1,
                        0, 1, 1, 1 }, // matrix for J

            new int[] { 1, 0, 0, 1,
                        1, 0, 1, 0,
                        1, 1, 0, 0,
                        1, 0, 1, 0,
                        1, 0, 0, 1 }, // matrix for K

            new int[] { 1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 0, 0, 0,
                        1, 1, 1, 0 }, // matrix for L

            new int[] { 1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for M

            new int[] { 1, 0, 0, 1,
                        1, 1, 0, 1,
                        1, 0, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for N

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for O

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 0, 0,
                        1, 0, 0, 0 }, // matrix for P

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 1, 0,
                        1, 1, 0, 1 }, // matrix for Q

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        1, 0, 1, 0,
                        1, 0, 0, 1 }, // matrix for R

            new int[] { 1, 1, 1, 1,
                        1, 0, 0, 0,
                        0, 1, 1, 0,
                        0, 0, 0, 1,
                        1, 0, 0, 1 }, // matrix for S

            new int[] { 1, 1, 1, 1,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        0, 1, 1, 0 }, // matrix for T

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        0, 1, 1, 0 }, // matrix for U

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        0, 1, 1, 0,
                        0, 1, 1, 0 }, // matrix for V

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 0, 0, 1,
                        1, 1, 1, 1,
                        0, 1, 1, 0 }, // matrix for U

            new int[] { 1, 0, 0, 1,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        0, 1, 1, 0,
                        1, 0, 0, 1 }, // matrix for X

            new int[] { 1, 0, 0, 1,
                        1, 0, 0, 1,
                        0, 1, 1, 1,
                        0, 0, 0, 1,
                        1, 1, 1, 1 }, // matrix for Y

            new int[] { 1, 1, 1, 1,
                        0, 0, 0, 1,
                        0, 0, 1, 0,
                        0, 1, 0, 0,
                        1, 1, 1, 1 }, // matrix for Z
        };

    public static int[][] GetTrainingData()
    {
        return trainingData;
    }
}
