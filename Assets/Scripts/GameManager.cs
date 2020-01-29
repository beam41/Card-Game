using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int turnCount { get; set; }

    public Player[] playerList;
    public CardManager cardManager;
    private Player CurrentPlayer;
    private int playerIndex;
    // You is Player_1
    private void Start()
    {
        playerIndex = 0;
        turnCount = 0;
        GameStart();
        turnStart(playerList[playerIndex]);
    }

    private void GameStart()
    {
        Debug.Log("GameStart");

        for(int i = 0; i< playerList.Length; i++)
        {
            cardManager.Draw(5, playerList[i]);
        }

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
        CurrentPlayer = player;
        CurrentPlayer.playerTurn = true;
        cardManager.Draw(1, CurrentPlayer);
        turnCount++;
    }

    private void changePlayerTurn()
    {
        CurrentPlayer.playerTurn = false;
        playerIndex = (playerIndex+1)%playerList.Length;
        turnStart(playerList[playerIndex]);
    }
}
