using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public bool inMenu;
    public GameObject menuPause;
    public GameObject gameOver;

    public void Start()
    {
        inMenu = false;
        menuPause.SetActive(false);
    }

    public void Update()
    {
        // Permet de mettre en pause avec Echap
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            inMenu = !inMenu;
            menuPause.SetActive(inMenu);
        }
    }

    // Permet de relancer le jeu de 0
    public void RestartGame()
    {
        inMenu = false;
        SceneManager.LoadScene("Game");
    }

    // Permet de revenir au menu principal  
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Permet de continuer le jeu
    public void ContinueGame()
    {
        inMenu = false;
        menuPause.SetActive(false);
    }

    public void GameOver(){
        inMenu = true;
        gameOver.SetActive(true);
    }
}
