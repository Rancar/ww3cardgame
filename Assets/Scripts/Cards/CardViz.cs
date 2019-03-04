using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardViz : MonoBehaviour
{
    public Text title;
    public Text cardText;
    public Image art;
    public Card card;
    public Text cardOil;
    public Text cardHearts;
    public Text cardHE;
    public Text cardPierce;

    private void Start()
    {
        LoadCard(card);
    }

    public void LoadCard(Card c)
    {
        if (c == null)
            return;

        card = c;
        title.text = c.cardName;
        if (string.IsNullOrEmpty(c.cardText))
        {
            cardText.gameObject.SetActive(false);
        }
        else
        {
            cardText.gameObject.SetActive(true);
            cardText.text = c.cardText;
        }
        
        art.sprite = c.art;
        cardOil.text = c.cardOil.ToString();
        cardHearts.text = c.cardHearts.ToString();
        cardHE.text = c.cardHE.ToString();
        cardPierce.text = c.cardPierce.ToString();
    
    }
}
