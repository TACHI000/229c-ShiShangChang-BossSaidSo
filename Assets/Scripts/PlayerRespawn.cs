using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector2 respawnPoint;

    void Start()
    {
        // จุดเริ่มต้นคือจุด spawn แรก
        respawnPoint = transform.position;
    }

    // เรียกตอนชน Checkpoint
    public void SetCheckpoint(Vector2 newCheckpoint)
    {
        respawnPoint = newCheckpoint;
    }

    // เรียกเมื่ออยากกลับไปเกิด
    public void Respawn()
    {
        transform.position = respawnPoint;
        Debug.Log("Respawned at " + respawnPoint);
    }
}
