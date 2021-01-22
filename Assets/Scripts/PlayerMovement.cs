using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
   
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + touch.deltaPosition.x * speed, transform.position.y);
            }
        }
    }
}
