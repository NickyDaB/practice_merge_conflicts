using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello_world : MonoBehaviour
{
    //Variables
    int result = 0;
    string PlayerName = "Alex";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }


    int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }

    void PrintPlayerName()
    {
        Debug.Log("The Player's Name is: " + PlayerName);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
