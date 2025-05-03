using UnityEngine;
using UnityEngine.UIElements;

public class WinCheck : MonoBehaviour
{
    public GameObject gameWinImage;
    public GameObject retryButt;


    void Start()
    {
        if (gameWinImage != null) gameWinImage.SetActive(false);
        if (retryButt != null) retryButt.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameWinImage != null) gameWinImage.SetActive(true);
            if (retryButt != null) retryButt.SetActive(true);

            Debug.Log("You Win");
            
        }
    }
}
