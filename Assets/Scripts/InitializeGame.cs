using UnityEngine;
using UnityEngine.SceneManagement;

public class InitializeGame : MonoBehaviour
{
    private float
        timer = 0f,
        timerEnd = 3f; // When Game Starts (Seconds)

    // On Game Start
    private void Start()
    {
        // Set Timer from MS to Seconds
        timerEnd *= 1000f; // (Times by 1000)

        // --- Set Game Properties ---

        Cursor.visible = Global.cursorVisible;
    }

    private void Update()
    {
        // Update Timer

        timer++; // Increment Timer

        // End Scene
        if (timer >= timerEnd)
        {
            // Load Next Scene
            SceneManager.LoadScene("Title");
        }
    }
}
