using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text pointsValue;

    void UpdateScore()
    {
        pointsValue.text = "" + GameManager.instance.timer.ToString("f0");
    }

    void Update()
    {
        UpdateScore();
    }
}
