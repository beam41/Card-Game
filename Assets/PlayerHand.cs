using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHand : MonoBehaviour
{
    private HorizontalLayoutGroup horizontalLayout;
    private List<CardDisplay> selectedCards;

    private void Start()
    {
        horizontalLayout = GetComponent<HorizontalLayoutGroup>();
    }


    public void disableLayout()
    {
        horizontalLayout.enabled = false;
    }

    public void enableLayout()
    {
        horizontalLayout.enabled = true;
    }
}
