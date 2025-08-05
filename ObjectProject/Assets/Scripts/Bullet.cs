using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f; //�Ѿ˼ӵ�
    public float life_time = 2.0f; //�Ѿ������ð�
    public GameObject effect_prefab; //����Ʈ ������

    private BulletPool pool;
    private Coroutine life_coroutine;


    public void SetPool(BulletPool pool)
    {
        this.pool = pool;
    }

    //Ȱ��ȭ �ܰ�
    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulletReturn());
    }

    //��Ȱ��ȭ �ܰ�
    private void OnDisable()
    {
        if (life_coroutine != null)
            StopCoroutine(life_coroutine);
    }

    private void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;
    }

    //�����ð������� ��Ȱ��ȭ
    IEnumerator BulletReturn()
    {
        yield return new WaitForSeconds(life_time);
        ReturnPool();
    }

    //������ ��Ȱ��ȭ
    private void OnTriggerEnter(Collider other)
    {
        //�ε��� ����� Enemy�±��ϰ�� ����������
        

        //����Ʈ(��ƼŬ)
        if(effect_prefab != null)
        {
            Instantiate(effect_prefab, transform.position, Quaternion.identity);
        }

        ReturnPool();
    }

    //��Ȱ��ȭ
    private void ReturnPool()
    {
        pool.Return(gameObject);
    }
}
