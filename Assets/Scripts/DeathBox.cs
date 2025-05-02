using UnityEngine;

public class DeathBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerRespawn player = other.GetComponent<PlayerRespawn>();
            if (player != null)
            {
                player.Respawn();

                // Å´ËÑÇã¨
                LifePoint lifeUI = FindObjectOfType<LifePoint>();
                if (lifeUI != null)
                {
                    lifeUI.TakeDamage();
                }
            }
        }
    }
}
