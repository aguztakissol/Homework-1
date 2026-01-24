using UnityEngine;
using UnityEngine.InputSystem;  // Include this for the new Input System

public class PlayerViewSwitch : MonoBehaviour
{
    // Input action for the button press
    public InputActionReference toggleViewAction;

    // The two positions to toggle between
    public Transform roomPosition;           // The player's position inside the room
    public Transform externalViewPosition;   // The external viewing point (outside the room)

    // Toggle to track which position we're in
    private bool isExternalView = false;

    void Start()
    {
        // Ensure the input action is enabled
        toggleViewAction.action.Enable();

        // Set the initial position (start inside the room)
        transform.position = roomPosition.position;
        transform.rotation = roomPosition.rotation;
    }

    void Update()
    {
        // Listen for the button press
        if (toggleViewAction.action.WasPressedThisFrame())
        {
            TogglePlayerView();
        }
    }

    void TogglePlayerView()
    {
        // Toggle the position between the room and the external view
        if (isExternalView)
        {
            // Switch to room position
            transform.position = roomPosition.position;
            transform.rotation = roomPosition.rotation;
        }
        else
        {
            // Switch to external view position
            transform.position = externalViewPosition.position;
            transform.rotation = externalViewPosition.rotation;
        }

        // Toggle the view state
        isExternalView = !isExternalView;
    }
}
