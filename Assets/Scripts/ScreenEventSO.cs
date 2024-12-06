using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "ScreenEvent")]
public class ScreenEventSO : ScriptableObject
{
    public UnityAction<Direction> Input;

    public UnityAction UP;
    public UnityAction DOWN;
    public UnityAction Left;
    public UnityAction Right;
    public UnityAction Enter;
    public UnityAction RRotate;
    public UnityAction LRotate;
    public UnityAction Open;


    public void InvokeEvent(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                UP?.Invoke();
                Debug.Log("up invoked");
                break;
            case Direction.Down:
                DOWN?.Invoke();
                Debug.Log("down invoked");
                break;
            case Direction.Left:
                Left?.Invoke();
                Debug.Log("left invoked");
                break;
            case Direction.Right:
                Right?.Invoke();
                Debug.Log("right invoked");
                break;
            case Direction.Enter:
                Enter?.Invoke();
                Debug.Log("enter invoked");
                break;
            case Direction.RRotate:
                RRotate?.Invoke();
                Debug.Log("RRotate invoked");
                break;
            case Direction.LRotate:
                LRotate?.Invoke();
                Debug.Log("LRotate invoked");
                break;
            case Direction.Open:
                Open?.Invoke();
                Debug.Log("Open invoked");
                break;
            default:
                break;
        }
    }
}

public enum Direction
{
    Up,
    Down,
    Left,
    Right,
    Enter,
    RRotate,
    LRotate,
    Open
}