using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Game Elements/My Hand Card")]
public class HandCard : GElement_Logic
{
    public override void OnClick(CardInstance inst)
    {
        Debug.Log("this card is on my hand");
    }

    public override void OnHighlight(CardInstance inst)
    {
        
    }


}
