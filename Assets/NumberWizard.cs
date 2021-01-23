using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxN = 1000;
        int minN = 42;
        
        Debug.Log("Welcome to number wizard, eyy");
        Debug.Log("Pick a number");
        Debug.Log("The Lowest number you can pick is: " + minN);
        Debug.Log("Highest number you can pick is: " + maxN) ;
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
        }
    }
}
