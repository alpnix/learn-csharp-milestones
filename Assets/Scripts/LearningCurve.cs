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

        Character hero = new Character("Player", 100);
        Character heroine = new Character("Enemy", 20);
        
        Debug.LogFormat("The name of the hero is {0} and their health is {1}", hero.name, hero.health);
        Debug.LogFormat("The name of the heroine is {0} and their health is {1}", heroine.name, heroine.health);

        Weapon huntingBow = new Weapon("Hunting Bow", 25);
        Weapon warBow = new Weapon("War Bow", 50);

        Debug.Log($"Weapon: {huntingBow.Name}, Damage: {huntingBow.Damage}");
        Debug.Log($"Weapon: {warBow.Name}, Damage: {warBow.Damage}");

        Weapon paladinWeapon = new Weapon("Holy Sword", 100);
        Paladin knight = new Paladin("Knight", 150, paladinWeapon);

        knight.PrintStatsInfo();


        Transform mainCameraTransform = GetComponent<Transform>();
        Debug.Log($"Main Camera Local Position: {mainCameraTransform.localPosition}");

        GameObject lightGameObject = GameObject.Find("Directional Light");

        if (lightGameObject != null)
        {
            Transform lightTransform = lightGameObject.GetComponent<Transform>();
            Debug.Log($"Light Local Position: {lightTransform.localPosition}");
        }
        else
        {
            Debug.LogWarning("Light GameObject not found! Ensure the Light is named 'Light' in the Hierarchy.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        float curTime = Time.time;
        
    //     if (curTime > 10000.0f) {
    //         if (true) {
    //             Debug.Log("This is always true");
    //         }
    //         Debug.Log("Time is greater than 10000 seconds");
    //     }
    //     else if (curTime > 1000.0f) {
    //         Debug.Log("Time is greater than 1000 seconds");
    //     }
    //     else {
    //         if (!true) {
    //             Debug.Log("This is always false"); // never prints
    //         }
    //         Debug.Log("Time is less than 1000 seconds");
    //     }

    //     switch (integer) {
    //         case 1:
    //             Debug.Log("The value of integer is 1");
    //             break;
    //         case 2:
    //             Debug.Log("The value of integer is 2");
    //             break;
    //         case 3:
    //             Debug.Log("The value of integer is 3");
    //             break;
    //         default:
    //             Debug.Log("The value of integer is not 1, 2, or 3");
    //             break;
    //     }
    // }

    // int[] arr = {"red", "green", "blue"};
    // Debug.Log(arr[1]);

    // int[] arr = {1, 2, 3, 4, 5};
    // List<string> colors = new List<string>(new string[] {"red", "green", "blue"});
    // Dictionary<string, int> colorToValue = new Dictionary<string, int> {
    //     {"red", 1},
    //     {"green", 2},
    //     {"blue", 3}
    // };

    // for (int i = 0; i < colors.Length; i++) {
    //     if (i == 2) {
    //         Debug.Log(colors[i]);
    //     }
    // }

    // foreach (string color in colors) {
    //     Debug.Log(color);
    // }

    // foreach (KeyValuePair<string, int> entry in colorToValue) {
    //     Debug.LogFormat("The value of {0} is {1}", entry.Key, entry.Value);
    // 
    }
}
