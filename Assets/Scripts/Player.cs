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


    private void Start()
    {
        playerTurn = false;
    }

    private void Update()
    {
        ThrowButton.SetActive(playerTurn);
        Timer.SetActive(playerTurn);
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
}
