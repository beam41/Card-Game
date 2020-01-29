using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int turnCount { get; set; }

    public Player[] playerArray;
    public CardManager cardManager;

    private void Start()
    {
        turnCount = 0;
    }
    private void Update()
    {
        
    }

    private void GameStart()
    {

    }
}
