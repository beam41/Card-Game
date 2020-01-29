using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondChecker
{
    public bool CheckThrowingCard(int CardNum, List<GameObject> CardList)
    {
        if (CardNum == 0) return false;
        else if (SumCharge(CardList) == 0) return true;
        else return false;
    }
    public int SumCharge(List<GameObject> CardList)
    {
        int result = 0;
        foreach (GameObject Card in CardList)
        {
            result += Card.GetComponent<CardDisplay>().card.charge;
        }

        return result;
    }
}
