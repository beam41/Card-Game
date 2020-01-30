using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Card3DDisplay : MonoBehaviour
{
    public List<Card> cards;
    public TextMeshProUGUI fullName;
    public TextMeshProUGUI symbol;
    public TextMeshProUGUI symbol_;
    public TextMeshProUGUI frontNum;
    public TextMeshProUGUI backNum;

    private string[] prefixNum = {"", "Mono", "Di", "Tri", "Tetra", "Penta", "Hexa", "Hepta", "Octa", "Nona", "Deca"};

    private void Start()
    {
        GenerateNameAndSymbol();
    }

    private void GenerateNameAndSymbol(){
        var atomList = new Dictionary<string, int>();
        int positiveCharge = 0;
        int negativeCharge = 0;
        Card positiveAtom = null;
        Card negativeAtom = null;

        foreach(Card card in cards){
            if(card.charge > 0){
                positiveCharge++;
                positiveAtom = card;
            }
            else if(card.charge < 0){
                negativeCharge++;
                negativeAtom = card;
            }
        }
        symbol.text = positiveAtom.symbol.ToString();
        symbol_.text = negativeAtom.symbol.ToString();
        // fullName.text =  positiveAtom.fullName.ToString();

        fullName.text = "";

        if(positiveCharge == 1) fullName.text += positiveAtom.fullName;
        else fullName.text += prefixNum[positiveCharge] + positiveAtom.fullName;
        if(negativeCharge == 1) fullName.text += negativeAtom.negativeName;
        else fullName.text += prefixNum[negativeCharge] + negativeAtom.negativeName;

        symbol.text = positiveAtom.symbol;
        symbol_.text = negativeAtom.symbol;
        frontNum.text = positiveCharge.ToString();
        backNum.text = negativeCharge.ToString();
    }

}
