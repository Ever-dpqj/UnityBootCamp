using UnityEngine;
using System.Collections;


public class CoroutineSample : MonoBehaviour
{
    //������ Ÿ��
    public GameObject target;

    //��ȭ �ð�
    float duration = 5.0f;

    //��
    public Color color;

    void Start()
    {
        //Ÿ���� �����Ǿ� �ִٸ�
        if(target != null)
        {
            StartCoroutine(ChangeColor());
            //�ش� �޼ҵ� IEnumerator ������ �޼ҵ带 �ڷ�ƾ���� ����
            //�ڵ��ۼ��������� �޼ҵ� �����Ǿ� ������
            //ȣ���ϱ⶧���� ���ڿ��� ã�°ͺ��� ����

            //StartCoroutine("ChangeColor");
            ////���ڿ��� ���� �Ű��������� �ڷ�ƾ ȣ�Ⱑ��
            //Ÿ��üũ �����ʾƼ� �߸��� �̸� ���� ��Ÿ�ӿ����߻�
        }
        else
        {
            Debug.LogWarning("���� Ÿ�� ���x");
        }

    }

    IEnumerator ChangeColor()
    {
        var targetRenderer = target.GetComponent<Renderer>();

        if (targetRenderer == null)
        {
            Debug.LogWarning("�������� ����������");
            yield break;
        }

        float time = 0.0f;
        var start = targetRenderer.material.color;
        var end = color;

        //�ݺ��۾�
        //�ڷ�ƾ �ݺ�������� yield�� ���� �����ٰ� ���ƿͼ� �ݺ�������
        while (time < duration)
        {
            time += Time.deltaTime;
            var value = Mathf.PingPong(time, duration) / duration;
            //Mathf.PingPong(a,b)
            //>> a,b���̿��� �ݺ��Ǵ� ���� ����(�պ��)
            //����ȭ�۾��� ���������� -> color >> 0~1������ ��

            targetRenderer.material.color = Color.Lerp(start, end, value);

            yield return null;
        }

    }
}
