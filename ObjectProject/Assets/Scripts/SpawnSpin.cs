using UnityEngine;

public class SpawnSpin : MonoBehaviour
{
    private int speed;

    void Start()
    {
        int random = Random.Range(0, 10);
        speed = 360 + random * 27;
    }


    void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
