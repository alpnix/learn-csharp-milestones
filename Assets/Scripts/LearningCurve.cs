using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int simpleMethod (int x) {
        Debug.Log("This is a simple method");
        return x * x; 
    }

    // Start is called before the first frame update
    public int integer = 15; 
    private float floatingPoint = 0.0f;
    public string text = "Hello World!";
    private bool boolean = true;

    // This is my single line comment
    /* 
    This is my 
    multi-line comment 
    */

    void Start()
    {
        Debug.Log(text); // runs on the console
        Debug.LogFormat("The value of integer is {0}", integer);
        Debug.Log($"{text} is a template string: " + text);
        Debug.Log($"The square of {integer} is {simpleMethod(integer)}");
        floatingPoint = 3.14f;
        Debug.Log(floatingPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
