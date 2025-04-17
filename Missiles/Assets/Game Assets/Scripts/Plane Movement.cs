using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [Header("Speed And Roational Values")]

    public float velocity;
    public float quaternion;

    [Header("Effects")]

    public ParticleSystem burstFX;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // smoothened movement
        transform.position += transform.up * velocity * Time.deltaTime;
        transform.Rotate(0f, 0f, -horizontal * quaternion * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Misile"))
        {
            burstFX.Play();
            // stop the game
        }
    }
}