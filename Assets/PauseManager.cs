using UnityEngine;
using UnityEngine.SceneManagement;

public class InGamePauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    private bool isPaused = false;

    void Start()
    {
        // Make sure time flows normally and panel is hidden on launch
        Time.timeScale = 1f;
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }
    }

    void Update()
    {
        // Rubric 7: Escape key pauses the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f; // Freeze game physics and movement
        isPaused = true;
    }

    // Rubric 8: Resume the game
    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f; // Restore normal speed
        isPaused = false;
    }

    // Rubric 9: Restart the game
    public void RestartGame()
    {
        Time.timeScale = 1f; // Always reset timeScale before reloading
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Rubric 10: Back to Main Menu
    public void BackToMainMenu()
    {
        Time.timeScale = 1f; // Always reset timeScale before returning to menu
        SceneManager.LoadScene(0);
    }
}