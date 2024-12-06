using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityFigmaBridge.Runtime.UI;

public class Screenlistener : MonoBehaviour
{
    public ScreenEventSO ScreenEventSO;
    [SerializeField] private Direction direction;


    [SerializeField] private string m_TargetScreenNodeId;
    public string TargetScreenNodeId
    {
        get => m_TargetScreenNodeId;
        set => m_TargetScreenNodeId = value;
    }

    private void OnEnable()
    {
        switch (direction)
        {
            case Direction.Up:
                ScreenEventSO.UP += Transition;
                break;
            case Direction.Down:
                ScreenEventSO.DOWN += Transition;
                break;
            case Direction.Left:
                ScreenEventSO.Left += Transition;
                break;
            case Direction.Right:
                ScreenEventSO.Right += Transition;
                break;
            case Direction.Enter:
                ScreenEventSO.Enter += Transition;
                break;
            case Direction.RRotate:
                ScreenEventSO.RRotate += Transition;
                break;
            case Direction.LRotate:
                ScreenEventSO.LRotate += Transition;
                break;
            default:
                break;
        }
    }

    private void OnDisable()
    {
        switch (direction)
        {
            case Direction.Up:
                ScreenEventSO.UP -= Transition;
                break;
            case Direction.Down:
                ScreenEventSO.DOWN -= Transition;
                break;
            case Direction.Left:
                ScreenEventSO.Left -= Transition;
                break;
            case Direction.Right:
                ScreenEventSO.Right -= Transition;
                break;
            case Direction.Enter:
                ScreenEventSO.Enter -= Transition;
                break;
            case Direction.RRotate:
                ScreenEventSO.RRotate -= Transition;
                break;
            case Direction.LRotate:
                ScreenEventSO.LRotate -= Transition;
                break;
            default:
                break;
        }


    }
    public void Transition()
    {
        var prototypeFlowController =
                GetComponentInParent<Canvas>().rootCanvas?.GetComponent<PrototypeFlowController>();

        if (prototypeFlowController != null)
            prototypeFlowController.TransitionToScreenById(TargetScreenNodeId);
    }
}
