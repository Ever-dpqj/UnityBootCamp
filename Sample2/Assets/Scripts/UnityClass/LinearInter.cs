using UnityEngine;

public class LinearInter : MonoBehaviour
{
    // Vector3.Lerp(start,end,t);
    // start -> end ���� t�� ���� ���� ����
    // �ش� �������� ���� ���� õõ�� �̵�
    // t(0~1) , float �ڷ���


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
