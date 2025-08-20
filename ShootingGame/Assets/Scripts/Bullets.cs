using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        Vector3 dir = Vector3.up;

        transform.position += dir * speed * Time.deltaTime;
    }
}
