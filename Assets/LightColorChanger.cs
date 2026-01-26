using UnityEngine;
using UnityEngine.InputSystem;  // Make sure to include the InputSystem namespace

public class LightColorChanger : MonoBehaviour
{
    
    private Light pointLight;

    
    public InputActionReference changeColorAction;

    // Colors to cycle through (or change this to any colors you want)
    public Color[] colors = new Color[] { Color.red, Color.green, Color.blue, Color.yellow };

    
    private int currentColorIndex = 0;

    void Start()
    {
        
        pointLight = GetComponent<Light>();

        
        changeColorAction.action.Enable();

       
        changeColorAction.action.performed += OnChangeColorPressed;
    }

    
    private void OnChangeColorPressed(InputAction.CallbackContext context)
    {
        
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        
        pointLight.color = colors[currentColorIndex];
    }

    void OnDestroy()
    {
        // Clean up the event listener when the object is destroyed
        changeColorAction.action.performed -= OnChangeColorPressed;
    }
}
