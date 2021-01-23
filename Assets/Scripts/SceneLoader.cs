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
        SceneManager.LoadScene("GameOver");
    }
    
    public void Play()
    {    
        SceneManager.LoadScene("Game");
        GameManager.instance.timer = 0;
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
