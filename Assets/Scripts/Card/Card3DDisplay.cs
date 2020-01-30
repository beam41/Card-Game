using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Card3DDisplay : MonoBehaviour
{
    public TextMeshProUGUI fullName;
    public TextMeshProUGUI symbolBack;
    public TextMeshProUGUI symbolFront;
    public TextMeshProUGUI frontNum;
    public TextMeshProUGUI backNum;

    private string[] prefixNum = {"", "Mono", "Di", "Tri", "Tetra", "Penta", "Hexa", "Hepta", "Octa", "Nona", "Deca"};

    public void GenerateNameAndSymbol(Card positiveAtom, int positiveCharge, Card negativeAtom, int negativeCharge){

        symbolFront.text = "";
        symbolBack.text = "";
        frontNum.text = "";
        backNum.text = "";

        if (positiveCharge == 0 && negativeCharge == 0){
            symbolFront.text = "";
            symbolBack.text = "";
            fullName.text = "Noble";
            return;
        }

        fullName.text = "";
        symbolFront.text = positiveAtom.symbol.ToString();
        symbolBack.text = negativeAtom.symbol.ToString();

        if(positiveCharge == 1) fullName.text += positiveAtom.fullName;
        else fullName.text += prefixNum[positiveCharge] + positiveAtom.fullName;
        if(negativeCharge == 1) fullName.text += negativeAtom.negativeName;
        else fullName.text += prefixNum[negativeCharge] + negativeAtom.negativeName;

        symbolFront.text = positiveAtom.symbol;
        symbolBack.text = negativeAtom.symbol;
        if(positiveCharge > 1) frontNum.text = positiveCharge.ToString();
        if (negativeCharge > 1) backNum.text = negativeCharge.ToString(); 

    }

    
}
