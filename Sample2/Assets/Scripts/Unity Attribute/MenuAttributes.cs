using UnityEngine;
//Attribute : [AddComponentMenu("")]ó�� Ŭ����,�Լ�,�����տ� �ٴ� []���� Attribute(�Ӽ�)�̶����
//�������� Ȯ�� or ����� ���� �� ���ۿ��� �����Ǵ� ��ɵ�
//��� ���� : ����ڰ� �����͸� �� ����������, ���������� ����ϱ� ����

//("�׷��̸�/����̸�") >> ���
[AddComponentMenu("Sample/AddComponentMenu")]//�޴�, ����̸�
//�׷��� ������� �׷� ����, �ƴҰ�� ��ɸ� ����.



public class NewMonoBehaviourScript : MonoBehaviour
{
    [ContextMenuItem("�޽��� �ʱ�ȭ", "MessageReset")]
    public string message = "";

    public void MessageReset()
    {
        message = "";
    }


    [ContextMenu("���޽���")]

    public void MenuAttributesMethod()
    {
        Debug.LogWarning("���");
    }
}
