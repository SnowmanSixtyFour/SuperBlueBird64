using UnityEngine;
using UnityEngine.UI;

public class LogoTitle : MonoBehaviour
{
    // Public Variables
    [SerializeField] private RawImage logo;

    [SerializeField] private float
        rotationAmount = 5f,
        rotationSpeed = 1f;

    private void Update()
    {
        // Rotate Logo

        float zRotation = Mathf.Sin(Time.time * rotationSpeed) * rotationAmount;

        if (OptionsManager.logoRotate) logo.transform.rotation = Quaternion.Euler(0f, 0f, zRotation);
    }
}
