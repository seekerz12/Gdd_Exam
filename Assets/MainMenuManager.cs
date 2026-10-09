using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Rubric 3: Navigate to Driving Game
    public void PlayMadDriver()
    {
        SceneManager.LoadScene(1);
    }

    // Rubric 4: Navigate to Flying Game
    public void PlayFlyLikeABird()
    {
        SceneManager.LoadScene(2);
    }

    // Rubric 5: Navigate to Sumo Game
    public void PlaySumoGame()
    {
        SceneManager.LoadScene(3);
    }

    // Rubric 6: Exit the game
    public void ExitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}