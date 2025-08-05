using UnityEngine;
using System.Collections;

public class IEnumeratorSample : MonoBehaviour
{
    class CustomCollection : IEnumerable
    {
        int[] numbers = { 6, 7, 8, 9, 10 };


        //numbers �迭 ��ȸ�ϴ� IEnumerator ������ ��ü�� ��ȯ
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return numbers[i];
            }
        }
    }

    int[] numbers = { 1, 2, 3, 4, 5 };

    void Start()
    {
        //numbers �迭 ��ȸ�ϴ� IEnumerator ������ �����ͷ� ��ȯ
        IEnumerator enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }//�������� ���������� �ݺ�

        CustomCollection collection = new CustomCollection();

        //foreach�� ��ȯ ������ �����͸� ���������� �۾��� �� ����ϴ� for��
        foreach (int number in collection)
        {
            Debug.Log(number);
        }

        IEnumeratorSample isample = new IEnumeratorSample();

        

        foreach (var message in GetMessage())
        {
            Debug.Log(message);
        }
    }



    //yield�� �ѹ��� �ϳ��� ���� �ѱ�� �޼ҵ尡 �Ͻ������Ǹ�, �ļӰ����� ���������� ��ȯ�ϰ� �մϴ�.
    //(�ݺ��۾�, �������� ������ ó���� ���)
    //yield return , yield break �� ���
    //�� �� ��ȯ�� ���ÿ� �Ͻ����� -> �������� �䱸�Ҷ�����
    //���� �ݺ� �����ϴ� �ڵ�
    //����: �ʿ��Ҷ����� ����� �̷�(�޸� ȿ��, ū������ ó�� ����)

    //IEnumerable : �ݺ������� �÷����� ��Ÿ���� �������̽�
    //�� �� ����� ������ Ŭ������ �ݺ����� ��ü�� �ǰ�, ������ Ž���� ��������
    //���� ����ϱ� ���ؼ� GetEnumerator() �޼ҵ带 �����ؾ���

    //IEnumerator : �ݺ��� �����ϴ� �������̽�
    //�� �÷��ǿ��� �׸��� ��ȯ, ���¸� �����ϴ� ���� ����
    //���� MoveNext(): ����������, Current: ���簪 Ȯ��, Reset(): ����


    static IEnumerable GetMessage()
    {
        Debug.Log("�޼ҵ� ����");
        yield return "��";
        Debug.Log("���ƿ�1");
        yield return "ȣ";
        Debug.Log("���ƿ�2");
        yield break;
        //�۾�����

        ////���ٺҰ� 
        //Debug.Log("3");
        //yield return "!";
    
    }
}

