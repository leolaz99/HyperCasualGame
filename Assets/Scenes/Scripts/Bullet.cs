using UnityEngine;

public class Bullet : MonoBehaviour
{
    Camera cam;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.SetActive(false);    
    }
    
        
    /// <summary>
    /// Funzione per disattivare  i nemici se questi oltrepassano lo schermo
    /// </summary>
    void CrossScreen()
    {
        Vector3 screenPoint = cam.WorldToViewportPoint(transform.position);

        if (screenPoint.y < 0f)
        {
            this.gameObject.SetActive(false);
        }
    }

    void Awake()
    {
        cam = FindObjectOfType<Camera>();
    }
    
    void Update()
    {
        CrossScreen();
    }
}
