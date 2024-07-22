using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeColor(Color.red);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeColor(Color.green);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeColor(Color.blue);
        }
    }

    void ChangeColor(Color newColor)
    {
        objectRenderer.material.color = newColor;
    }
}
