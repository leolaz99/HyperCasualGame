using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    
    /// <summary>
    /// Funzione per andare alla schermata di sconfitta
    /// </summary>
    public void LoseScreen()
    {
    }

    /// <summary>
    /// Funzione per ricominciare il gioco
    /// </summary>
    public void Retry()
    {
    }

    /// <summary>
    /// Funzione per uscire dal gioco
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    } 


    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
