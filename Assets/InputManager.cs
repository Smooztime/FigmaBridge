using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public ScreenEventSO ScreenEventSO;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.S)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.A)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.J)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.K)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Up);
        }
        

    }
}
