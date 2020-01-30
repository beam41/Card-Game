using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int turnCount { get; set; }

    public Player[] playerList;
    public CardManager cardManager;
    public Player CurrentPlayer;
    private int playerIndex;
    private float timer;
    public TextMeshProUGUI TurnCounter;
    public TextMeshProUGUI TimeCounter;

    private void Start()
    {
        playerIndex = 0;
        turnCount = 0;
        GameStart();
    }

    private void Update()
    {
        TurnCounter.text = "Turn: " + turnCount.ToString() + "\n" + CurrentPlayer.playerName + "'s turn.";
        TimeCounter.text = "Time Remaining\n" + timer.ToString("00.00");
        timer -= Time.deltaTime;
        if (timer <= 0) PlayerPass();
    }

    private void GameStart()
    {
        Debug.Log("GameStart");

        for(int i = 0; i< playerList.Length; i++)
        {
            cardManager.Draw(5, playerList[i]);
        }
        turnStart(playerList[playerIndex]);

    }

    public void PlayerThrowCard()
    {
        cardManager.Throw(CurrentPlayer);
        changePlayerTurn();
    }

    public void PlayerPass()
    {
        cardManager.Pass(CurrentPlayer);
        changePlayerTurn();
    }

    private void turnStart(Player player)
    {
        timer = 10f;
        CurrentPlayer = player;
        CurrentPlayer.playerTurn = true;
        CurrentPlayer.enabled = true;
        cardManager.Draw(1, CurrentPlayer);
        turnCount++;
    }

    private void changePlayerTurn()
    {
        CurrentPlayer.enabled = false;
        CurrentPlayer.playerTurn = false;
        playerIndex = (playerIndex+1)%playerList.Length;
        turnStart(playerList[playerIndex]);
    }
}
