using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardViz : MonoBehaviour
{
    /*public Text title;
    public Text cardText;
    public Image art;    
    public Text cardOil;
    public Text cardHearts;
    public Text cardHE;
    public Text cardPierce;*/
    public Card card;
    public CardVizProperties[] properties;

    private void Start()
    {
        LoadCard(card);
    }

    public void LoadCard(Card c)
    {
        if (c == null)
            return;

        card = c;

        for (int i = 0; i < c.properties.Length; i++)
        {
            CardProperties cp = c.properties[i];
            CardVizProperties p = GetProperty(cp.element);

            if (p == null)
            {
                continue;
            }

            if (cp.element is ElementInt)
            {
                p.text.text = cp.intValue.ToString();
            }
            else if (cp.element is ElementText)
            {
                p.text.text = cp.stringValue;
            }
            else if (cp.element is ElementImage)
            {
                p.image.sprite = cp.sprite;
            }
        }
        /*title.text = c.cardName;
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
    */
    }

    public CardVizProperties GetProperty(Element e)
    {
        CardVizProperties result = null;

        for (int i = 0; i < properties.Length; i++)
        {
            if (properties[i].element == e)
            {
                result = properties[i];
                break;
            }
        }

        return result;
    }
}
