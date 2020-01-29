using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public GameManager gameManager;
    public void BotStart()
    {
        gameManager.PlayerPass();
    }
}
