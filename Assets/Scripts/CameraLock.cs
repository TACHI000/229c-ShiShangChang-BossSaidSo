using UnityEngine;

public class CameraLock : MonoBehaviour
{

    public Transform target;      // Assign player here
    public Vector3 offset;        // Offset from the player
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Keep Z fixed (for 2D)
        smoothedPosition.z = transform.position.z;

        transform.position = smoothedPosition;
    }
}
