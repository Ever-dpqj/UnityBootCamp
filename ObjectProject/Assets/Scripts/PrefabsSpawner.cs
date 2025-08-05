using UnityEngine;

public class PrefabsSpawner : MonoBehaviour
{
    public GameObject prefab;
    private GameObject spawned;
    public float delay = 3.0f;


    void Start()
    {
        if (prefab != null)
        {
            spawned = Instantiate(prefab);
            //�����ε�
            //(prefab) : �ش������������� ���� ����
            //(prefab, transform.position, Quaternion,identity) : ������ ��ġ�� ȸ���������� ����
            //(prefab, parent) : ������Ʈ�� �θ��� �ڽ��� ��ġ�� ����
            //(prefab, transform.position, Quaternion,identity, parent) : «��

            spawned.name = "�����ȿ�����Ʈ";

            Debug.Log(spawned.name + "�� �����Ǿ����ϴ�.");

            Destroy(spawned, delay);    
        }
        else
        {
            Debug.LogWarning("��ϵ� �������� �����ϴ�.");
        }
    }
}
