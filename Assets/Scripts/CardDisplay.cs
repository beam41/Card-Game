using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public TextMeshProUGUI charge;
    public TextMeshProUGUI fullName;
    public TextMeshProUGUI symbol;
    public PlayerHand playerHandScript;
    
    private bool selected = false;
    
    private void Start()
    {
        if(card.charge > 0) charge.text = "+" + card.charge.ToString(); 
        else if(card.charge < 0) charge.text = "-" + card.charge.ToString();
        else charge.text = "";
        fullName.text = card.fullName.ToString();
        symbol.text = card.symbol.ToString ();
    }

    public void SelectCard()
    {
        playerHandScript.disableLayout();
        if (!selected)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+30f, 0);
            selected = true;
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y-30f, 0);
            selected = false;
        }

    }
}
