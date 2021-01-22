using UnityEngine;

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
        timer += Time.deltaTime;
    }
}
