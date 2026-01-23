using UnityEngine;
using UnityEngine.InputSystem; // Required if you use the New Input System

public class PointLightController : MonoBehaviour
{
    private Light pointLight; // reference to the Light component
    public InputAction changeColorAction; // Input Action to trigger color change

    void Start()
    {
        // Get the Light component attached to this GameObject
        pointLight = GetComponent<Light>();
    }

    void OnEnable()
    {
        changeColorAction.Enable(); // enable input
    }

    void OnDisable()
    {
        changeColorAction.Disable(); // disable input
    }

    void Update()
    {
        // Check if the controller button was pressed
        if (changeColorAction.triggered)
        {
            // Change the light color to a random color
            pointLight.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
