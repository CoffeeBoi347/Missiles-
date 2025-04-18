using System.Collections;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameManager gameManager;

    [Header("Speed And Roational Values")]

    public float velocity;
    public float quaternion;

    [Header("Effects")]

    public ParticleSystem burstFX;

    [Header("Other Booleans")]

    public bool hasCollided = false;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();  
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // smoothened movement
        transform.position += transform.up * velocity * Time.deltaTime;
        transform.Rotate(0f, 0f, -horizontal * quaternion * 0.5f * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Misile"))
        {
            hasCollided = true;
            burstFX.Play();
            gameManager.isGameOver = true;
            StartCoroutine(SetTimeScaleToZero(0.5f));
        }
    }

    private IEnumerator SetTimeScaleToZero(float time)
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0f;
    }
}