using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnStartGame()
    {
        // Vai para seleção de fase
        SceneManager.LoadScene("LevelSelect");
    }

    public void OnRanking()
    {
        // Pode carregar uma cena de ranking ou abrir um painel
        // Para simplificar, podemos ter uma cena "Ranking" no futuro
        SceneManager.LoadScene("RankingScene"); // ou implementar depois
    }

    public void OnExit()
    {
        Application.Quit();

        // No editor não fecha, então só pra debug:
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
