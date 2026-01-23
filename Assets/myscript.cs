using UnityEngine;
using UnityEngine.InputSystem;

public class myscript : MonoBehaviour
{
    public InputActionReference action
    void Start()
    {
        action.action.Enable();
        action.action.performed +- (ctx) =>
        {
        #if UNITY EDITOR
        UnityEditor.EditorApplication.isPlaying= false;
        #else 
            Application();
        #endif

        };
    }
}