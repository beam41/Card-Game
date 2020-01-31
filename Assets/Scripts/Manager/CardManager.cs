using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public GameObject CardTemplate;
    public GameObject[] Card3DTemplate;

    public Transform CardSpawnPoint;
    public BondChecker bondChecker;
    public GameObject Model;
    public Camera firstPersonCamera;

    //Card
    public Card[] AkiliMetal;
    public Card[] AkaliEarthMetal;
    public Card[] Halogen;
    public Card[] NobleGas;
    public Card[] NonMetal;


    private void Start() {
        firstPersonCamera = GameObject.FindGameObjectWithTag("MainCamera").transform.GetChild(0).GetComponent<Camera>();
    }

    public void Draw(int n, Player player)
    {
        SetAllCardNotSelected(player);
        for (int i = 0; i < n; i++)
        {
            Instantiate(RandomCard(player)).transform.SetParent(player.PlayerHand.transform);
        }
        player.playerHandScript.enableLayout();

    }

    public void Throw(Player currentPlayer)
    {
        int CardNum = 0;
        List<GameObject> CardList = new List<GameObject>();
        List<Card> Cards = new List<Card>();
        for (int i = 0; i < currentPlayer.PlayerHand.transform.childCount; i++)
        {
            GameObject currentCard = currentPlayer.PlayerHand.transform.GetChild(i).gameObject;
            if (currentCard.GetComponent<CardDisplay>().isSelected())
            {
                CardList.Add(currentCard);
                Cards.Add(currentCard.GetComponent<CardDisplay>().card);
                CardNum++;
            }
        }
        if (bondChecker.CheckThrowingCard(CardNum, CardList))
        {
            Debug.Log("Matched Card");
            currentPlayer.addScore(CardNum);
            var newCard = Instantiate(getThrowingCard(Cards), CardSpawnPoint.position, CardSpawnPoint.rotation);
            if(firstPersonCamera != null)
                newCard.transform.GetChild(0).GetComponent<Canvas>().worldCamera = firstPersonCamera;
            newCard.transform.SetParent(Model.transform);
            
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


    // Expandsion Method
    private void SetAllCardNotSelected(Player player)
    {
        for (int i = 0; i < player.PlayerHand.transform.childCount; i++)
        {
            player.PlayerHand.transform.GetChild(i).GetComponent<CardDisplay>().setToNotSelected();
        }
    }
    private GameObject RandomCard(Player player)
    {
        CardTemplate.GetComponent<CardDisplay>().playerHandScript = player.playerHandScript;
        int randomNum = Random.Range(0, 100);
        if (randomNum < 25) CardTemplate.GetComponent<CardDisplay>().card = AkiliMetal[Random.Range(0, AkiliMetal.Length)];
        else if (randomNum >= 25 && randomNum < 40) CardTemplate.GetComponent<CardDisplay>().card = AkaliEarthMetal[Random.Range(0, AkaliEarthMetal.Length)];
        else if (randomNum >= 40 && randomNum < 65) CardTemplate.GetComponent<CardDisplay>().card = NonMetal[Random.Range(0, NonMetal.Length)];
        else if (randomNum >= 65 && randomNum < 90) CardTemplate.GetComponent<CardDisplay>().card = Halogen[Random.Range(0, Halogen.Length)];
        else if (randomNum >= 90 && randomNum < 100) CardTemplate.GetComponent<CardDisplay>().card = NobleGas[Random.Range(0, NobleGas.Length)];
        return CardTemplate;
    }

    private GameObject getThrowingCard(List<Card> cards){
        int positiveCharge = 0;
        int negativeCharge = 0;
        Card positiveAtom = null;
        Card negativeAtom = null;

        foreach (Card card in cards)
        {
            if (card.charge > 0)
            {
                positiveCharge++;
                positiveAtom = card;
            }
            else if (card.charge < 0)
            {
                negativeCharge++;
                negativeAtom = card;
            }

        }
        if(positiveAtom.symbol.Length == 1)
        {
            if(negativeAtom.symbol.Length == 1)
            {
                Card3DTemplate[0].GetComponent<Card3DDisplay>().GenerateNameAndSymbol(positiveAtom, positiveCharge, negativeAtom, negativeCharge);
                return Card3DTemplate[0];
            }
            else
            {
                Card3DTemplate[1].GetComponent<Card3DDisplay>().GenerateNameAndSymbol(positiveAtom, positiveCharge, negativeAtom, negativeCharge);
                return Card3DTemplate[1];

            }
        }
        else
        {
            if (negativeAtom.symbol.Length == 1)
            {
                Card3DTemplate[2].GetComponent<Card3DDisplay>().GenerateNameAndSymbol(positiveAtom, positiveCharge, negativeAtom, negativeCharge);
                return Card3DTemplate[2];

            }
            else
            {
                Card3DTemplate[3].GetComponent<Card3DDisplay>().GenerateNameAndSymbol(positiveAtom, positiveCharge, negativeAtom, negativeCharge);
                return Card3DTemplate[3];

            }
        }
        //Card3DTemplate.GetComponent<Card3DDisplay>().cards = cards;
        
    }



}
