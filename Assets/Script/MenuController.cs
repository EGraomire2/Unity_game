using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public bool inMenu = false;
    public GameObject menuPause;
    public GameObject gameOver;

    public void Start()
    {
        this.inMenu = false;
        gameOver.SetActive(false);
        menuPause.SetActive(false);
    }

    public void Update()
    {
        // Permet de mettre en pause avec Echap
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            print(this.inMenu);
            this.inMenu = !inMenu;
            print(this.inMenu);
            menuPause.SetActive(this.inMenu);
        }
    }

    // Permet de relancer le jeu de 0
    public void RestartGame()
    {
        inMenu = false;
        SceneManager.LoadScene("game");
    }

    // Permet de revenir au menu principal  
    public void QuitGame()
    {
        SceneManager.LoadScene("menu");
    }

    // Permet de continuer le jeu
    public void ContinueGame()
    {
        inMenu = false;
        menuPause.SetActive(false);
    }

    public void GameOver()
    {
        this.inMenu = true;
        //gameOver.SetActive(true);
        gameOver.SetActive(true);
        //menuPause.SetActive(true);
    }

    public void StopGame()
    {
        Application.Quit();
    }
}
