using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GameObject target;
    public float smoothSpeed = 0.125f;

    void Update()
    {
        Vector3 desiredPosition = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
