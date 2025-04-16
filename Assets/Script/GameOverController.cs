using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void LoadGame()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("MenuScene");
    }
}
