﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Actions/MouseOverDetection")]
public class MouseOverDetection : Action
{
    public override void Execute(float d)
    { 
       PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        IClickable c = null;

        foreach (RaycastResult r in results)
        {    
            c = r.gameObject.GetComponentInParent<IClickable>();
            if (c != null)
            {
                c.OnHighlight();
                break;
            }
        }
    }
}
