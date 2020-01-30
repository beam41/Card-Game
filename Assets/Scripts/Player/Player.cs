using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public bool playerTurn { get; set;}
    public string playerName = "";
    public GameObject PlayerHand;
    public PlayerHand playerHandScript;
    public GameObject ThrowButton;
    public GameObject Timer;
    public Bot BotScript;
    [SerializeField] private float PlayerScore;
    public bool bot = false;
    public TextMeshProUGUI Score;
    private void Awake() {
        playerTurn = false;
    }

    private void Update()
    {
        Debug.Log(playerName + ": " + playerTurn);
        Score.text = "Score\n"+PlayerScore.ToString("000");
        
        if (bot && playerTurn)
        {
            BotScript.BotStart();
        }
    }

    public void addScore(int n)
    {
        PlayerScore += Mathf.Pow(2, n);
    }

    public void activeUI(){
        ThrowButton.SetActive(true);
        Timer.SetActive(true);
    }
    public void deactiveUI(){
        ThrowButton.SetActive(false);
        Timer.SetActive(false);
    }
}
