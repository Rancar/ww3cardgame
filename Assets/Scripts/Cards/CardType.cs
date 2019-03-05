using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardType : ScriptableObject
{
    public string typeName;

    public virtual void OnSetType(CardViz viz)
    {
        Element t = GameManager.GetResourcesManager().typeElement;
        CardVizProperties type = viz.GetProperty(t);
        type.text.text = typeName;
    }

}
