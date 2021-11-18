using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;

    public UnityEngine.UI.Button StartButton;

    public GameObject StartScreen;
    public GameObject PlayScreen;
   

    public void StartGame()
    {
        this.Message.text = "Can you save the Snowman?";
        this.StartButton.gameObject.SetActive(false);
        
        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }
    public void OpenStartScreen()
    {
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
    }



}


