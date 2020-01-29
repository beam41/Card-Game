using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Card3DDisplay : MonoBehaviour
{
    public Card card;
    public TextMeshProUGUI charge;
    public TextMeshProUGUI fullName;
    public TextMeshProUGUI symbol;

    private void Update()
    {
        if (card.charge > 0) charge.text = "+" + card.charge.ToString();
        else if (card.charge < 0) charge.text = card.charge.ToString();
        else charge.text = "";
        fullName.text = card.fullName.ToString();
        symbol.text = card.symbol.ToString();
    }

}
