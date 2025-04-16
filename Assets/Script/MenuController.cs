using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public bool inMenu = false;
    public GameObject menuPause;

    public void Start()
    {
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
        menuPause.SetActive(false);
    }
}
