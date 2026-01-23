using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public float rotationSpeed = 20f; // degrees per second

    void Update()
    {
        // Rotate around Y-axis using deltaTime for smooth frame-rate independent motion
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}