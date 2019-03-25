using UnityEngine;
using System.Collections;

public class CardInstance : MonoBehaviour, IClickable
{
    public GElement_Logic currentLogic;

    public void OnClick()
    {
        if (currentLogic == null)
            return;

        currentLogic.OnClick(this);
    }

    public void OnHighlight()
    {
        if (currentLogic == null)
            return;

        Debug.Log("highlights");
        currentLogic.OnHighlight(this);
    }
}
