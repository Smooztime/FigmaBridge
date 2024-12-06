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
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Down);
        }
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Left);
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Right);
        }
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            ScreenEventSO.InvokeEvent(Direction.Enter);
        }
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            ScreenEventSO.InvokeEvent(Direction.RRotate);
        }
        if (Input.GetKeyDown(KeyCode.K)) 
        {
            ScreenEventSO.InvokeEvent(Direction.LRotate);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            ScreenEventSO.InvokeEvent(Direction.Open);
        }
    }
}
