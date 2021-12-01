using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;

    public UnityEngine.UI.Text GetWord;

    public UnityEngine.UI.Text CheckGuess;

    public UnityEngine.UI.Text GuessesRemaining;

    public UnityEngine.UI.Text GetGuessedLetters;

    public UnityEngine.UI.Button StartButton;

    public GameObject StartScreen;
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
    }

    public void SubmitGuess()
    {
        string guess = PlayerGuess.text;
        Debug.Log(guess);
        GetWord.text = this.guessingGame.GetWord();
        GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
        CheckGuess.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        PlayerGuess.text = string.Empty;
    }

    public void GameOverScreen()
    {
        PlayerLost.text = this.guessingGame.PlayerLost();
        CorrectWord.text = this.guessingGame.CorrectWord();
         this.StartButton.gameObject.SetActive(false);
    }

    

}


