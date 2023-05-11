using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private string name;

    private Color color;
    // Start is called before the first frame update
    void Start()
    {
        name = "John";
        color = Color.cyan;
        Debug.Log($"The name of the cat is {name}");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"The color of the cat is {color}");
        
    }
}
