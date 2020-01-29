using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public GameObject CardTemplate;
    public HorizontalLayoutGroup horizontalLayout;
    private BondChecker bondChecker = null;

    //Card
    public Card[] AkiliMetal;
    public Card[] AkaliEarthMetal;
    public Card[] Halogen;
    public Card[] NobleGas;
    public Card[] NonMetal;
    private void Start()
    {

    }

    public void Draw(int n, Player player)
    {
        SetAllCardNotSelected(player);
        player.playerHandScript.enableLayout();
        for (int i = 0; i < n; i++)
        {
            Instantiate(RandomCard()).transform.SetParent(player.PlayerHand.transform);
        }
    }
    private GameObject RandomCard()
    {
        int[] RandomSet = { 1, 1, 2, 3, 4, 5, 6, 6, 7, 7, 7, 8 }; //{1, 1, 1, 3, 4, 5, 6, 7, 7, 7, 8}
        int SetNum = Random.Range(0, RandomSet.Length);
        if (SetNum == 1) CardTemplate.GetComponent<CardDisplay>().card = AkiliMetal[Random.Range(0, AkiliMetal.Length)];
        else if (SetNum == 2) CardTemplate.GetComponent<CardDisplay>().card = AkiliMetal[Random.Range(0, AkiliMetal.Length)];
        else if (SetNum == 3) CardTemplate.GetComponent<CardDisplay>().card = AkaliEarthMetal[Random.Range(0, AkaliEarthMetal.Length)];
        else if (SetNum == 4) CardTemplate.GetComponent<CardDisplay>().card = NonMetal[Random.Range(0, NonMetal.Length)];
        else if (SetNum == 5) CardTemplate.GetComponent<CardDisplay>().card = NonMetal[Random.Range(0, NonMetal.Length)];
        else if (SetNum == 6) CardTemplate.GetComponent<CardDisplay>().card = NonMetal[Random.Range(0, NonMetal.Length)];
        else if (SetNum == 7) CardTemplate.GetComponent<CardDisplay>().card = Halogen[Random.Range(0, Halogen.Length)];
        else if (SetNum == 8) CardTemplate.GetComponent<CardDisplay>().card = NobleGas[Random.Range(0, NobleGas.Length)];
        return CardTemplate;
    }
    public void Throw(Player currentPlayer)
    {
        //Debug.Log(PlayerHand.transform.childCount);
        int CardNum = 0;
        List<GameObject> CardList = new List<GameObject>();
        for (int i = 0; i < currentPlayer.PlayerHand.transform.childCount; i++)
        {
            GameObject currentCard = currentPlayer.PlayerHand.transform.GetChild(i).gameObject;
            if (currentCard.GetComponent<CardDisplay>().isSelected())
            {
                CardList.Add(currentCard);
                CardNum++;
            }
        }
        if (bondChecker.CheckThrowingCard(CardNum, CardList))
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
            Draw(1, currentPlayer);
        }
        currentPlayer.playerHandScript.enableLayout();
    }

    public void Pass(Player currentPlayer)
    {
        Draw(1, currentPlayer);
    }

    private void SetAllCardNotSelected(Player player)
    {
        for (int i = 0; i < player.PlayerHand.transform.childCount; i++)
        {
            player.PlayerHand.transform.GetChild(i).GetComponent<CardDisplay>().setToNotSelected();
        }
    }



}
