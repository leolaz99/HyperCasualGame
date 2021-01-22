using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    
    /// <summary>
    /// Funzione per andare alla schermata di sconfitta
    /// </summary>
    public void Lose()
    {
    }

    /// <summary>
    /// Funzione per ricominciare il gioco
    /// </summary>
    public void Retry()
    {
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
