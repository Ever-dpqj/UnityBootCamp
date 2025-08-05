using UnityEngine;

//����Ƽ�� ȸ��

//1. ���Ϸ����� ���� xyzȸ����
//transform�� rotation�� ǥ��Ȱ�

//2. ���ʹϾ� - ȸ���� ����ϱ⿡ �������� �������� ����� ���� ��
//���ο��� ������ ����ǰ� ���Ǵ� ��


//���ʹϾ����� ó���ϴ� ����
//���� -> ���Ϸ� ��ȯ�� 360�� �̻��� ȸ���� ������ �� ����
// 380 -> 20

//���� �� ����(Gimbal Lock) : 2���� ���� ���ĵǴ� ����, ȸ�������� 2���� ���� ����

//���ʹϾ� ->> (x,y,z,w)   |   w : ��Į��
//���ʹϾ� ���Ϳ� ���� ������ ���ÿ� ȸ���� ������ ����
//������ ���ÿ� ȸ�� ->> ������ ���� �߻�x
//������ ������ ���� ȸ���� ������ �� ����

//���� : 180�� �̻��� ǥ�� �Ұ� / ���������� �ʴ�


public class ObjectRotate : MonoBehaviour
{

    void Start()
    {

        
    }



    void Update()
    {
        //transform.Rotate()�� ���� �⺻���� ȸ�� ���� �ڵ�
        //(Vector3 eulerAngles) or (float x,float y,float z) or (Vector3 axis, float angle) or (Vector3 axis, float angle, Space.space)

        //������Ʈ ���� ȸ��
        //transform.Rotate(new Vector3(20, 20, 20) * Time.deltaTime);

        //������ǥ ���� ȸ��
        transform.Rotate(new Vector3(20, 20, 20) * Time.deltaTime, Space.World);
    }
}
