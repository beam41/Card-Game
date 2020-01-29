using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playerTurn { get; set;}
    public GameObject PlayerHand;
    public PlayerHand playerHandScript;
    public GameObject ThrowButton;
    public Bot BotScript;
    public bool bot = false;

    private void Start()
    {
        playerTurn = false;
    }

    private void Update()
    {
        ThrowButton.SetActive(playerTurn);
        if (bot && playerTurn)
        {
            BotScript.BotStart();
        }
    }
}
