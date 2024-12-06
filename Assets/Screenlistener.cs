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

        }
    }

    private void OnDisable()
    {
        switch (direction)
        {
            case Direction.Up:
                ScreenEventSO.UP -= Transition;
                break;

        }


    }

    public void Transition()
    {
        // Get prototype flow controller (assumed attached to root canvas)
        var prototypeFlowController =
            GetComponentInParent<Canvas>().rootCanvas?.GetComponent<PrototypeFlowController>();

        if (prototypeFlowController != null)
            prototypeFlowController.TransitionToScreenById(TargetScreenNodeId);
    }

}
