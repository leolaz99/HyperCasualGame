using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [HideInInspector]
    public float timer;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
            instance = this;
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if(currentScene.name == "Game")
            timer += Time.deltaTime;
    }
}
