using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxN = 1000;
    int minN = 42;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Sup ya'll it's me, ya boy NumbaWizard");
        Debug.Log("Pick a number");
        Debug.Log("The Lowest number you can pick is: " + minN);
        Debug.Log("Highest number you can pick is: " + maxN) ;
        Debug.Log("Tell me if your number is higher or lower " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxN = maxN + 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minN = guess;
            guess = (maxN + minN) / 2;
            Debug.Log("Up = My number is higher than:" + guess);
            Debug.Log("Down = My number is lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxN = guess;
            guess = (maxN + minN) / 2;
            Debug.Log("Up = My number is higher than:" + guess);
            Debug.Log("Down = My number is lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Am so smart");
        }
                
    }
}
