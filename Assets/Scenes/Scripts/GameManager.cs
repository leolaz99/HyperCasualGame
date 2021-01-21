using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int points = 0;
    public static GameManager instance;
    float timer;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
            instance = this;
    }

    void Update()
    {
        timer += Time.deltaTime;
    }
}
