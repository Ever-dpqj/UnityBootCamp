using UnityEngine;
//Mathf -> ���а��� ��ƿ��Ƽ Ŭ����
//ex)Mathf.Abs(-5);

//�����޼ҵ� : static���� ���� / Ŭ������.�޼ҵ������ ��� ����


public class MathfSample : MonoBehaviour
{
    float abs =  -5;
    float ceil = 4.1f;
    float floor = 4.6f;
    float round = 4.5f;
    float clamp;
    float clamp1;
    float pow = 1111;
    float sqrt = 100;


    void Start()
    {
        Debug.Log(Mathf.Abs(abs));//����(absolute number)
        Debug.Log(Mathf.Ceil(ceil));//�ø�
        Debug.Log(Mathf.Floor(floor));//����
        Debug.Log(Mathf.Round(round));//�ݿø�
        Debug.Log(Mathf.Clamp(7, 0, 4));//��, �ּ�, �ִ� -> �� �ּҰ�or�ִ� ����
        Debug.Log(Mathf.Clamp01(5));//���� ���� �� = 5 / �ּ�=0, �ִ�=1 / �ۼ�Ʈ �� ó���Ҷ� ����
        //Clamp >> ü��, ����, �ӵ� ����
        //Clamp01 >> ����(�ۼ�Ʈ), ������, ���İ�(����) 

        Debug.Log(Mathf.Pow(pow, 2));//���� / ��, ����
        Debug.Log(Mathf.Sqrt(sqrt));//��Ʈ
    }

    void Update()
    {
        
    }
}
