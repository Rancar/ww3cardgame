using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card")]
public class Card : ScriptableObject
{
    /*public string cardName;
    public Sprite art;
    public string cardText;
    public int cardOil;
    public int cardHearts;
    public int cardHE;
    public int cardPierce;*/

    public CardType cardType;
    public CardProperties[] properties;

}
