using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int turnCount { get; set; }

    public Player[] playerList;
    public CardManager cardManager;
    private Player CurrentPlayer;

    private void Start()
    {
        turnCount = 0;
        GameStart();
        CurrentPlayer = playerList[0];
        
    }

    private void GameStart()
    {
        Debug.Log("GameStart");
        //cardManager.Draw(5, playerList[0]);
        for(int i = 0; i< playerList.Length; i++)
        {
            cardManager.Draw(5, playerList[i]);
        }
    }
}
