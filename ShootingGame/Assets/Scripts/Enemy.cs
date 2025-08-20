using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        Vector3 dir = Vector3.down;
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
