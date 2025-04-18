using UnityEngine;

public class SpriteDestroy : MonoBehaviour
{
    private void Update()
    {
        Destroy(gameObject, 2.5f);
    }
}