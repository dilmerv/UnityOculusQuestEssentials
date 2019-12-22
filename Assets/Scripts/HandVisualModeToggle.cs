using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandVisualModeToggle : MonoBehaviour
{
    [SerializeField]    
    private float handVisualModeChangeInSeconds = 3.0f;

    private float internalTimer = 0;

    void Update()
    {
        if(internalTimer >= handVisualModeChangeInSeconds)
        {
            Hands.Instance.SwitchVisualization();
            internalTimer = 0;
        }
        else 
        {
            internalTimer += Time.deltaTime * 1.0f;
        }
    }
}
