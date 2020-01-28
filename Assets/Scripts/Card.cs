using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public int charge;
    public string fullName;
    public string symbol;

    public void Print()
    {
        Debug.Log(symbol + " : " + fullName + " : " + charge);
    }

}
