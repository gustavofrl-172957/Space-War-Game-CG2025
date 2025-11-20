using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelectController : MonoBehaviour
{
    public void OnEasy()
    {
        GameSettings.Difficulty = Difficulty.Easy;
        SceneManager.LoadScene("GameScene");
    }

    public void OnMedium()
    {
        GameSettings.Difficulty = Difficulty.Medium;
        SceneManager.LoadScene("GameScene");
    }

    public void OnHard()
    {
        GameSettings.Difficulty = Difficulty.Hard;
        SceneManager.LoadScene("GameScene");
    }

    public void OnBackToLevels()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
