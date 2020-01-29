using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playerTurn { get; set;}
    public GameObject PlayerHand;
    public PlayerHand playerHandScript;

    private void Start()
    {
        playerTurn = false;
        
    }
}
