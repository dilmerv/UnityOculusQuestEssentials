using UnityEngine;

[RequireComponent(typeof(OVRPlayerController))]
public class VRController : MonoBehaviour
{
    private OVRPlayerController controller;

    [SerializeField]
    private float moveSpeedMultiplier = 3.0f;

    [SerializeField]
    private bool allowDoubleXSpeed = false;

    void Start()
    {
        controller = GetComponent<OVRPlayerController>();
        controller.SetMoveScaleMultiplier(moveSpeedMultiplier);
    }

    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            controller.Jump();
        }

        if(OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger) && allowDoubleXSpeed)
        {
            controller.SetMoveScaleMultiplier(moveSpeedMultiplier * 2.0f);
        }
        else 
        {
            controller.SetMoveScaleMultiplier(moveSpeedMultiplier);
        }
    }
}
