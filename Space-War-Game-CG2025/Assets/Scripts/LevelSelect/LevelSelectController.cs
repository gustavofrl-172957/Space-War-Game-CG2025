using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectController : MonoBehaviour
{
    public void OnSelectLevel1()
    {
        GameSettings.LevelIndex = 1;
        SceneManager.LoadScene("DifficultySelect");
    }

    public void OnSelectLevel2()
    {
        GameSettings.LevelIndex = 2;
        SceneManager.LoadScene("DifficultySelect");
    }

    public void OnSelectLevel3()
    {
        GameSettings.LevelIndex = 3;
        SceneManager.LoadScene("DifficultySelect");
    }

    public void OnBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
