using UnityEngine;
//Mathf �����.



public class MathfConstant : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Mathf.PI);//3.1415926535
        Debug.Log(Mathf.Infinity);//���Ѵ�
        Debug.Log(Mathf.NegativeInfinity);//���ǹ��Ѵ�
        //ex) ������0
        //ex) float �������� ū���� ����(float.MaxValue)
        Debug.Log(Mathf.Sqrt(-1));//NaN(Not a Naumber)
        //using System.Numveriics;
        //Complex c= Complex.Sqrt(-1);
        //����) WebGL�� ����� ���ѵǴ� ��찡 ����


        //NaN
        //1. NaN������ �� �Ұ���( == �Ұ���)
        // -->> float.IsNaN() ����ϱ�
        Vector3 pos = transform.position;
        if (float.IsNaN(pos.x))
        {
            pos = Vector3.zero;
        }

        // �� �̿��� ��
        // Mathf.Deg2Rad() : Degree�� ��������
        // Mathf.Rad2Deg() : ������ ������
        // Mathf.Epsilon : float ���� 0�� ���� ����� 0�� �ƴ� �����





    }
}
