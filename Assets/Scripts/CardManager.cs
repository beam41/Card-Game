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
        playerHandScript.enableLayout();
        for (int i = 0; i < n; i++)
        {
            int rand_num = Random.Range(0, 0);
            CardTemplate.GetComponent<CardDisplay>().card = allCard[rand_num];
            CardTemplate.GetComponent<CardDisplay>().playerHandScript = playerHandScript;
            Instantiate(CardTemplate).transform.SetParent(PlayerHand.transform);

        }

    }

    public void Throw()
    {

    }

    public void Pass()
    {

    }
}
