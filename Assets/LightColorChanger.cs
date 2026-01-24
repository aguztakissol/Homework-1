using UnityEngine;
using UnityEngine.InputSystem;  // Make sure to include the InputSystem namespace

public class LightColorChanger : MonoBehaviour
{
    // Reference to the Light component on this GameObject
    private Light pointLight;

    // Reference to the Input Action (e.g., button press on controller)
    public InputActionReference changeColorAction;

    // Colors to cycle through (or change this to any colors you want)
    public Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.yellow };

    // Index to track which color we're currently on
    private int currentColorIndex = 0;

    void Start()
    {
        // Get the Light component attached to the same GameObject
        pointLight = GetComponent<Light>();

        // Make sure the InputAction is enabled
        changeColorAction.action.Enable();

        // Set up the event for when the action is performed (button press)
        changeColorAction.action.performed += OnChangeColorPressed;
    }

    // This function is called when the input action is triggered (e.g., button press)
    private void OnChangeColorPressed(InputAction.CallbackContext context)
    {
        // Cycle through the colors
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        // Change the light color
        pointLight.color = colors[currentColorIndex];
    }

    void OnDestroy()
    {
        // Clean up the event listener when the object is destroyed
        changeColorAction.action.performed -= OnChangeColorPressed;
    }
}
