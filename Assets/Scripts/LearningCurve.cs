using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    int integer = 0; 
    float floatingPoint = 0.0f;
    string text = "Hello World!";
    bool boolean = true;

    // This is my single line comment
    /* 
    This is my 
    multi-line comment 
    */

    void Start()
    {
        Debug.Log(text); // runs on the console
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
