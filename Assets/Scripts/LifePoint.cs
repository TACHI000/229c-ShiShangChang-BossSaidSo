using UnityEngine;
using UnityEngine.UI;

public class LifePoint : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;

    public Image[] hearts;
    public Sprite heartFull;
    public Sprite heartEmpty;

    public GameObject gameOverImage;

    void Start()
    {
        currentLives = maxLives;
        UpdateHearts();

        if (gameOverImage != null) gameOverImage.SetActive(false);
    }

    public void TakeDamage()
    {
        currentLives--;
        currentLives = Mathf.Clamp(currentLives, 0, maxLives);
        UpdateHearts();

        if (currentLives <= 0)
        {
            Debug.Log("Game Over");
            if (gameOverImage != null) gameOverImage.SetActive(true);
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentLives)
                hearts[i].sprite = heartFull;
            else
                hearts[i].sprite = heartEmpty;
        }
    }
}
