using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityFigmaBridge.Runtime.UI;

public class StatusbarActive : MonoBehaviour
{
    public ScreenEventSO ScreenEventSO;
    [SerializeField] private GameObject statusBar;
    [SerializeField] private GameObject miniStatusBar;
    [SerializeField] private GameObject maxLineBar;

    private bool isActive = true;

    private void Update()
    {
        if (isActive)
        {
            statusBar.SetActive(true);
            miniStatusBar.SetActive(false);
            maxLineBar.SetActive(false);
        }
        else
        {
            statusBar.SetActive(false);
            miniStatusBar.SetActive(true);
            maxLineBar.SetActive(true);
        }
    }

    private void OnEnable()
    {
        ScreenEventSO.Open += Transition;
    }
            

    private void OnDisable()
    {
        ScreenEventSO.Open -= Transition;
    }

    public void Transition()
    {
        isActive = !isActive;
    }
}
