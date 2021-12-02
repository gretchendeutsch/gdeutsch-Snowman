using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;

    public UnityEngine.UI.Text GetWord;

    public UnityEngine.UI.Text CheckGuess;

    public UnityEngine.UI.Text PlayerWon;

    public UnityEngine.UI.Text GuessesRemaining;

    public UnityEngine.UI.Text GetGuessedLetters;

    public UnityEngine.UI.Button StartButton;

    public UnityEngine.UI.Button StartGameButton;

    public UnityEngine.UI.Button PlayAgainButton;

    public GameObject StartScreen;

    public GameObject GameWonScreen;

 public GameObject GameOverScreen;


    public UnityEngine.UI.Text PlayerLost;
    public GameObject PlayScreen;

    private WordGuesser.WordGame guessingGame;

    public UnityEngine.UI.InputField PlayerGuess;


    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
        this.Message.text = "Can you save/n the Snowman?";
        this.StartButton.gameObject.SetActive(false);
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);

    }
    public void OpenStartScreen()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
    }

    public void Start()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
        GameOverScreen.SetActive(false);

    }

    public void SubmitGuess()
    {
        string guess = PlayerGuess.text;
        Debug.Log(guess);
        GetWord.text = this.guessingGame.GetWord();
        GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
        CheckGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        PlayerGuess.text = string.Empty;

        if(this.guessingGame.IsGameOver())
        {
            this.ShowGameOverScreen();
        }

        if(this.guessingGame.IsGameWon())
        {
            this.ShowGameWonScreen();
        }


    }

    public void ShowGameOverScreen()
    {
        PlayerLost.text = $"You lost. The word was: {this.guessingGame.GetFullWord()}";
        
        GameOverScreen.SetActive(true);
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(false);
        this.StartGameButton.gameObject.SetActive(true);

    }

    public void ShowGameWonScreen()
    {
        PlayerWon.text = $"You won!";
        GameWonScreen.SetActive(true);
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(false);
        this.PlayAgainButton.gameObject.SetActive(true);
        
    }

}


