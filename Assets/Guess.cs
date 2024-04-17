
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


using TMPro;


public class GuessTheNumber : MonoBehaviour
{   //Store variables
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField inputField;
    int number = 0;
    int numberOfGuesses = 0;
    int input;

    private void Start()
    {
        GameSetup();
    }

    
    void Update()
    {

    }



    public void GameSetup()
    {

        // Choose a random number between 1 and 10
        number = Random.Range(1, 11);
        //Debug.Log(number);

        // Update guesses remaining
        numberOfGuesses = 3;

        // Update the header text 
        Debug.Log("Please guess a number between 1 and 10.  You have 3 attempts to guess.");

        

    }

    public void SubmitGuess()
    {
        
        
        

        if (input > number)
        {
           Debug.Log("Incorrect, Too high!");
            return;
        }
        else if (input < number)
        {
            Debug.Log("Incorrect, Too low!");
        }
        // Decrease remaining attempts
        numberOfGuesses = numberOfGuesses - 1;

        // Update header text if correct
        if (input == number)
        {
            Debug.Log(" Correct, You won!");
        }
        // Update header text if incorrect
        else if (numberOfGuesses > 0)
        {
            // Show try again
            Debug.Log("Try again! " + numberOfGuesses.ToString() + " guesses remaining");
        }
        // If guess incorrect and guesses are done
        else
        {
            Debug.Log("Game Over!");
        }
    }

}