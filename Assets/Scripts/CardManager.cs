using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public GameObject PlayerHand;
    public GameObject CardTemplate;
    public Card[] allCard;
    public HorizontalLayoutGroup horizontalLayout;
    private PlayerHand playerHandScript;
    private void Start()
    {
        playerHandScript = PlayerHand.GetComponent<PlayerHand>();
    }

    public void Draw(int n)
    {
        SetAllCardNotSelected();
        playerHandScript.enableLayout();
        for (int i = 0; i < n && allCard.Length != 0; i++)
        {
            int rand_num = Random.Range(0, allCard.Length);
            CardTemplate.GetComponent<CardDisplay>().card = allCard[rand_num];
            CardTemplate.GetComponent<CardDisplay>().playerHandScript = playerHandScript;
            Instantiate(CardTemplate).transform.SetParent(PlayerHand.transform);

        }
    }

    public void Throw()
    {
        //Debug.Log(PlayerHand.transform.childCount);
        int CardNum = 0;
        List<GameObject> CardList = new List<GameObject>();
        for (int i = 0; i < PlayerHand.transform.childCount; i++)
        {
            GameObject currentCard = PlayerHand.transform.GetChild(i).gameObject;
            if (currentCard.GetComponent<CardDisplay>().isSelected())
            {
                CardList.Add(currentCard);
                CardNum++;
            }
        }
        if (CheckThrowingCard(CardNum, CardList))
        {
            Debug.Log("Matched Card");
            foreach (GameObject Card in CardList)
            {
                Destroy(Card);
            }
        }
        else
        {
            Debug.Log("Not match Card.");
            Draw(1);
        }
        playerHandScript.enableLayout();
    }

    private int SumCharge(List<GameObject> CardList)
    {
        int result = 0;
        foreach (GameObject Card in CardList)
        {
            result += Card.GetComponent<CardDisplay>().card.charge;
        }

        return result;
    }


    public void Pass()
    {
        Draw(1);
    }

    private void SetAllCardNotSelected()
    {
        for (int i = 0; i < PlayerHand.transform.childCount; i++)
        {
            PlayerHand.transform.GetChild(i).GetComponent<CardDisplay>().setToNotSelected();
        }
    }

    private bool CheckThrowingCard(int CardNum, List<GameObject> CardList)
    {
        if (CardNum == 0) return false;
        else if (SumCharge(CardList) == 0) return true;
        else return false;
    }

}
