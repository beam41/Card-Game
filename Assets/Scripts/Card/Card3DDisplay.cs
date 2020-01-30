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

    private void Start()
    {
        
    }

    private void GenerateNameAndSymbol(){
        var atomList = new Dictionary<string, int>();


        // foreach(Card card in cards){
        //     if(atomList.ContainsKey(card.name)){
        //         atomList[card.name]++;
        //     }
        //     else{
        //         atomList[card.name] = 1;
        //     }
        // }

        
    }

}
