using UnityEngine;

//��ǥ �������� ȸ����Ű�� �ڵ�

public class TargetObject : MonoBehaviour
{

    public Transform target;

    public float speed = 90.0f; //�ʴ� ȸ���ӵ�




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Ư�������� �ٶ󺸴� ȸ��
        var targetRotation = Quaternion.LookRotation(target.position - transform.position);
        
        //(��ġ, Ÿ����ġ, �ӵ�)
        //����ȸ������ Ÿ����ȸ������ �ε巴�� ȸ������
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
