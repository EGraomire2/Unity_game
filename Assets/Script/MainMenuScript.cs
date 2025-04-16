using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void quit(){
        Application.Quit();
    }
}
