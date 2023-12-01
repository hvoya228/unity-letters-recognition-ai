using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isFilled = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (isFilled)
        {
            spriteRenderer.color = Color.white;
        }
        else
        {
            spriteRenderer.color = Color.black;
        }

        isFilled = !isFilled;
    }

    public int GetInputData()
    {
        return isFilled ? 1 : 0;
    }
}
