using UnityEngine;
using UnityEngine.UIElements;

public class WinCheck : MonoBehaviour
{
    public GameObject gameWinImage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameWinImage != null)
            {
                gameWinImage.SetActive(true);
            }

            Debug.Log("You Win");
            
        }
    }
}
