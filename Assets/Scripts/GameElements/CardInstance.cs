using UnityEngine;
using System.Collections;

public class CardInstance : MonoBehaviour, IClickable
{
    public void OnClick()
    {
        Vector3 s = Vector3.one / 2;
        this.transform.localScale = s;
    }

    public void OnHighlight()
    {
        Vector3 s = Vector3.one * 2;
        this.transform.localScale = s;
    }
}
