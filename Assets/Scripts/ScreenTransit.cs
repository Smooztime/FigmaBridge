using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityFigmaBridge.Runtime.UI;

public class ScreenTransit : MonoBehaviour
{
    [SerializeField] private float seconds;

    [SerializeField] private string m_TargetScreenNodeId;
    public string TargetScreenNodeId
    {
        get => m_TargetScreenNodeId;
        set => m_TargetScreenNodeId = value;
    }

    private void Start()
    {
        StartCoroutine(Transition());
    }

    private IEnumerator Transition()
    {
        yield return new WaitForSeconds(seconds);
        // Get prototype flow controller (assumed attached to root canvas)
        var prototypeFlowController =
            GetComponentInParent<Canvas>().rootCanvas?.GetComponent<PrototypeFlowController>();

        if (prototypeFlowController != null)
            prototypeFlowController.TransitionToScreenById(TargetScreenNodeId);
    }
}
