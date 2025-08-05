using UnityEngine;
using System.Collections.Generic;

//������Ʈ Ǯ��
//���� �����ǰ� �Ҹ�Ǵ� ������Ʈ�� �̸� �����صΰ�
//��/������ �����ϴ� ����� ���� ����

//��� ����
//new, destroy �ݺ� >> GC�� ���� ȣ�� >> ���� ����

public class BulletPool : MonoBehaviour
{
    public GameObject bullet_Prefab;
    public int count = 30;

    //Ǯ�� ���� ���Ǵ� ����
    //����Ʈ : �߰� ���� ������
    //ť : ���Լ���
    private List<GameObject> pool;

    private void Start()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < count; i++) //count��ŭ ������ ��Ȱ��ȭ, ����Ʈ�� �߰�
        {
            var bullet = Instantiate(bullet_Prefab);
            bullet.transform.parent = transform; //�Ҹ��� ���� �ڽ�
            
            bullet.SetActive(false);

            bullet.GetComponent<Bullet>().SetPool(this);

            pool.Add(bullet);
        }
    }

    //������Ʈ Ȱ��ȭ
    public GameObject GetBullet()
    {
        foreach (GameObject bullet in pool)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        // ��� �Ҹ��� ������̸� ���� ����
        var new_bullet = Instantiate(bullet_Prefab);
        new_bullet.transform.parent = transform;
        new_bullet.GetComponent<Bullet>().SetPool(this);
        pool.Add(new_bullet);
        return new_bullet;
    }
    public void Return(GameObject bullet)
    {
        bullet.SetActive(false);
    }
}
