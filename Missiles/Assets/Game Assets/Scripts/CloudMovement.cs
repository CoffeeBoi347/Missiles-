using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float velocity;

    private void Update()
    {
        transform.Translate(0f, -velocity * Time.deltaTime, 0f);
    }
}