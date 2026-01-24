using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TriggerInput : MonoBehaviour
{
    public InputActionProperty triggerAction; // Link this in the Inspector

    void Update()
    {
        // Check if the trigger was pressed this frame
        if (triggerAction.action.WasPressedThisFrame())
        {
            Debug.Log("Trigger pressed!");
        }
    }
}
