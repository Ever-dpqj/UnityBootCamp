using UnityEngine;

public class LinearInter : MonoBehaviour
{
    // Vector3.Lerp(start,end,t);
    // start -> end 까지 t에 따라 선형 보간
    // 해당 방향으로 일정 간격 천천히 이동
    // t(0~1) , float 자료형


    public Transform target;
    public float speed = 1.0f;

    private Vector3 start_position;
    private float t = 0.0f;
    void Start()
    {
       start_position = transform.position;
    }

    void Update()
    {
        if (t < 1.0f)
        {
            t += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(start_position, target.position, t);
        }
    }

}
