using UnityEngine;

//���ʹϾ� ��� ����
//Quarternion.identity = ȸ������
//Quarternion.Enler(x,y,z) = ���Ϸ�����ȯ
//Quarternion.AngleAxis(angle, axis) Ư�� �� ���� ȸ��
//Quarternion.LookRotation(forward, upward) �ش� ������ �ٶ󺸴� ȸ������ ��ȯ

//forward : ȸ�� ���� ����
//Upward : ������ �ٶ󺸰� �������� ���κ��� ����(�⺻���� up�̶� Ư���Ѱ�찡 �ƴ϶�� �ǵ�x)

//ȸ���� ����
//transform.rotation = Quarternion.Euler(x,y,z) : ���� ������Ʈ�� ȸ������ �����մϴ�.

//ȸ���� ���� ����
//Quarternion.Slerp(from, to, t) ���� ���� ����
//Quarternion.lerp(form, to, t) ���� ����
//Quarternion.RotateTowards(from, to, maxDegree) ����������ŭ ���������� ȸ��

//1.LookAt(target):�߰� ȸ�� �����̳� ��� ��ư�, �������� �������� transforem.rotation�� �ڵ�����
//2.LookRotation(direction)�� ���� ȸ������ ����ϰ� �������� ��������� x
//-->����� ��, �߰������۾����� ���ó�� ����


public class QuaternionSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
