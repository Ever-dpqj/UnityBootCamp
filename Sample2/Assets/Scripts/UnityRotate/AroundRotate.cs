using UnityEngine;

public class AroundRotate : MonoBehaviour
{

    public Transform pivot;
    public float speed = 50.0f;



    void Update()
    {
        transform.RotateAround(pivot.position, Vector3.up, speed * Time.deltaTime);    
    }
}
