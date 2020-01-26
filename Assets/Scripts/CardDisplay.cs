using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text number;
    private void Start()
    {
        number.text = card.number.ToString();
    }
}
