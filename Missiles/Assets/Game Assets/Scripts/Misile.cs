using System.Collections;
using UnityEngine;

public class Misile : MonoBehaviour
{
    public float velocity;
    public float quaternion;
    public Rigidbody2D rb;
    public GameObject target;
    public GameObject squareSprite;
    public float timeLimit;
    public bool hasReachedTimeLimit = false;
    public float timer = 0f;
    private void Update()
    {
        Vector2 direction = target.transform.position - transform.position;
        rb.velocity = transform.up * velocity * Time.deltaTime;
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -rotateAmount * quaternion * Time.deltaTime;

        if (!hasReachedTimeLimit)
        {
            Debug.Log("WE HAVE NOT REACHED THE LIMIT YET....!");
            timer += Time.deltaTime;
            if(timer >= timeLimit)
            {
                Debug.Log("INSTANTIATING....!");
                Instantiate(squareSprite, transform.position, transform.rotation);
                hasReachedTimeLimit = true;
                StartCoroutine(SetTimeReachedLimitToFalse(timeLimit * 0.1f));
                timer = 0f;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Misile"))
        {
            Debug.Log("DESTROYING GAME OBJECT...!");
            Destroy(gameObject);
        }
    }

    private IEnumerator SetTimeReachedLimitToFalse(float time)
    {
        yield return new WaitForSeconds(time);
        hasReachedTimeLimit = false;
    }
}