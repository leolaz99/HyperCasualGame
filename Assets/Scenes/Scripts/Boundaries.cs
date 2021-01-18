using UnityEngine;

public class Boundaries : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), transform.position.y);
    }
}
