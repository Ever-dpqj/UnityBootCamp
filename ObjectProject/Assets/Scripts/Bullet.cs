using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f; //총알속도
    public float life_time = 2.0f; //총알유지시간
    public GameObject effect_prefab; //이펙트 프리팹

    private BulletPool pool;
    private Coroutine life_coroutine;


    public void SetPool(BulletPool pool)
    {
        this.pool = pool;
    }

    //활성화 단계
    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulletReturn());
    }

    //비활성화 단계
    private void OnDisable()
    {
        if (life_coroutine != null)
            StopCoroutine(life_coroutine);
    }

    private void Update()
    {
        transform.position -= transform.up * speed * Time.deltaTime;
    }

    //유지시간지나면 비활성화
    IEnumerator BulletReturn()
    {
        yield return new WaitForSeconds(life_time);
        ReturnPool();
    }

    //닿으면 비활성화
    private void OnTriggerEnter(Collider other)
    {
        //부딪힌 대상이 Enemy태그일경우 데미지입힘
        

        //이펙트(파티클)
        if(effect_prefab != null)
        {
            Instantiate(effect_prefab, transform.position, Quaternion.identity);
        }

        ReturnPool();
    }

    //비활성화
    private void ReturnPool()
    {
        pool.Return(gameObject);
    }
}
