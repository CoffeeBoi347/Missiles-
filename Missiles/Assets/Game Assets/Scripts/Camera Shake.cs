using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [Header("Values")]

    public float xRange;
    public float yRange;
    public float cameraShakeTime = 0.3f;

    [Header("Other Scripts")]

    public PlaneMovement playerMovement;

    private void Start()
    {
        playerMovement = FindObjectOfType<PlaneMovement>();
    }
    private void Update()
    {
        if (playerMovement.hasCollided)
        {
            StartCoroutine(StartCameraShake());
        }
    }

    private IEnumerator StartCameraShake()
    {
        Vector3 camPosition = Camera.main.transform.position;
        float elapsedTime = 0f;
        while(elapsedTime < cameraShakeTime)
        {
            xRange = Random.Range(-xRange, xRange);
            yRange = Random.Range(-yRange, yRange);
            transform.position = new Vector2(transform.position.x + xRange, transform.position.y + yRange);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = camPosition;
    }
}