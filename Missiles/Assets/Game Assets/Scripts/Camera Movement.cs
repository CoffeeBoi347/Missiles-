using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 targetPosition;
    public float maxDistanceDelta;
    private void Update()
    {
        Vector3 newPos = target.transform.position + targetPosition;
        Vector3 newTargetPos = Vector3.MoveTowards(transform.position, newPos, maxDistanceDelta * Time.deltaTime);
        transform.position = newTargetPos;
    }
}