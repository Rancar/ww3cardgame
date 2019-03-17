using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public State currentState;

    public void Update()
    {
        currentState.Tick(Time.deltaTime);
    }
}
