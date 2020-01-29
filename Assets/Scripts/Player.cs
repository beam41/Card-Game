using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool playerTurn { get; set;}
    public GameObject PlayerHand;
    private PlayerHand playerHandScript;

    private void Start()
    {
        playerTurn = false;
        playerHandScript = PlayerHand.GetComponent<PlayerHand>();

    }
}
