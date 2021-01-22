using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRate;
    float spawnTimer;

    public GameObject prefab;
    GameObject enemy;
    ObjectPooler pooling = new ObjectPooler(true);

    void Awake()
    {
        pooling.Init(prefab, 7);
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if(spawnTimer > spawnRate)
        {     
            enemy = pooling.Instantiate(prefab);
            float rand = Random.Range(0.05f, 0.95f);
            enemy.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(rand, 1f, 1f));
            spawnTimer = 0;
        }
    }
}
