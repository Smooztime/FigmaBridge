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

    public UnityEvent Close;


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
                break;
            case Direction.Left:
                Left?.Invoke();
                break;
            case Direction.Right:
                Right?.Invoke();
                break;
            case Direction.Enter:
                Enter?.Invoke();
                break;
            case Direction.RRotate:
                RRotate?.Invoke();
                break;
            case Direction.LRotate:
                LRotate?.Invoke();
                break;
            case Direction.Open:
                Open?.Invoke();
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