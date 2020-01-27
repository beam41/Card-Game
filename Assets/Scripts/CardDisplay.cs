using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text number;
    public PlayerHand playerHandScript;
    
    private bool selected = false;
    
    private void Start()
    {
        number.text = card.number.ToString();
    }

    public void SelectCard()
    {
        playerHandScript.disableLayout();
        Debug.Log(gameObject.transform.position);
        if (!selected)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+50f, 0);
            selected = true;
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y-50f, 0);
            selected = false;
        }

    }
}
