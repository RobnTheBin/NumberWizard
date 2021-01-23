using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxN;
    int minN;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();     
    }

    void StartGame()
    {
        maxN = 1000;
        minN = 42;
        guess = 500;

        Debug.Log("Sup ya'll it's me, ya boy NumbaWizard");
        Debug.Log("Pick a number");
        Debug.Log("The Lowest number you can pick is: " + minN);
        Debug.Log("Highest number you can pick is: " + maxN);
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
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxN = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Am so smart");
            StartGame();        }
    }
    void NextGuess()
    {
        guess = (maxN + minN) / 2;
        if (guess - maxN == 0 || guess - minN ==0)
        {
            Debug.Log("You Lie it is " + guess + " I'm never wrong. Press enter to admit it.");
        }
        else
        {
            Debug.Log("Up = My number is higher than:" + guess);
            Debug.Log("Down = My number is lower than: " + guess);
            Debug.Log("Enter = My number is : " + guess);
        }
    }
}
