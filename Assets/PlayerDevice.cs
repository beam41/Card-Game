using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDevice : MonoBehaviour
{
    public GameObject OwnerDevice;
    public GameObject PlayerHand;
    public GameManager gameManager;
    private Player OwnerPlayer;

    private void Start() {
        PlayerHand.SetActive(true);
        // OwnerDevice.SetActive(true);
        OwnerPlayer = OwnerDevice.GetComponent<Player>();
    }
    private void Update() {
        if(OwnerPlayer.playerName == gameManager.CurrentPlayer.playerName 
        && OwnerPlayer.playerTurn == gameManager.CurrentPlayer.playerTurn){
            OwnerPlayer.activeUI();
        }
        else{
            OwnerPlayer.deactiveUI();
        }
    }
}
