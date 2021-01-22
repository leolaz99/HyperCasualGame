using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
