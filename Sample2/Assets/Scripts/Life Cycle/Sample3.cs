using UnityEngine;
//������Ʈ ĳ�̿� ����
//ĳ�� : ���ֻ��Ǵ� �����͸� �̸� �����صδ� �ӽ� ���

//�ð� ������ : ���� �ֱ� ���� �ٽ� ���� ���ɼ��� ����
//���� ������ : �ֱٿ� ������ �ּҿ� ������ �ּҰ� �ٽ� ''

public class Sample3 : MonoBehaviour
{

    Rigidbody rb;
    Vector3 pos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    //ĳ��
    }

    void Update()
    {
        rb.AddForce(pos*5);
    }
}
