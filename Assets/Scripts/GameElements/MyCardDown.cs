using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Game Elements/My Card Down")]
public class MyCardDown: GElement_Logic
{
    public override void OnClick(CardInstance inst)
    {
        Debug.Log("this card is mine but it's on the table");
    }

    public override void OnHighlight(CardInstance inst)
    {

    }


}
