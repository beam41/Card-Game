using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Card3DDisplay : MonoBehaviour
{
    public List<Card> cards;
    //public TextMeshProUGUI charge;
    public TextMeshProUGUI fullName;
    public TextMeshProUGUI symbol;

    private void Start()
    {
        // if (card.charge > 0) charge.text = "+" + card.charge.ToString();
        // else if (card.charge < 0) charge.text = card.charge.ToString();
        // else charge.text = "";
        // fullName.text = card.fullName.ToString();
        // symbol.text = card.symbol.ToString();

    }

    private void GenerateNameAndSymbol(){

    }

}
