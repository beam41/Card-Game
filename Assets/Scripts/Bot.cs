using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public GameManager gameManager;
    public void BotStart()
    {
        Debug.Log("Bot pass");
        StartCoroutine(waitSomthing());
        gameManager.PlayerPass();
    }

    IEnumerator waitSomthing(){

        yield return new WaitForSeconds(5f);
    }
}
