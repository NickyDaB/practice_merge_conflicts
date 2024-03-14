using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello_world : MonoBehaviour
{
    //Variables
    int result = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
