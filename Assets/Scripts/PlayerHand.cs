using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHand : MonoBehaviour
{
    public HorizontalLayoutGroup horizontalLayout;

    public void disableLayout()
    {
        horizontalLayout.enabled = false;
    }

    public void enableLayout()
    {
        horizontalLayout.enabled = true;
    }
}
