using UnityEngine;
using System.Collections.Generic;

//오브젝트 풀링
//자주 생성되고 소멸되는 오브젝트를 미리 생성해두고
//온/오프로 재사용하는 방식의 설계 패턴

//사용 목적
//new, destroy 반복 >> GC가 많이 호출 >> 성능 저하

public class BulletPool : MonoBehaviour
{
    public GameObject bullet_Prefab;
    public int count = 30;

    //풀에 자주 사용되는 구조
    //리스트 : 추가 삭제 자유롭
    //큐 : 선입선출
    private List<GameObject> pool;

    private void Start()
    {
        pool = new List<GameObject>();

        for (int i = 0; i < count; i++) //count만큼 생성후 비활성화, 리스트에 추가
        {
            var bullet = Instantiate(bullet_Prefab);
            bullet.transform.parent = transform; //불릿은 나의 자식
            
            bullet.SetActive(false);

            bullet.GetComponent<Bullet>().SetPool(this);

            pool.Add(bullet);
        }
    }

    //오브젝트 활성화
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

        // 모든 불릿이 사용중이면 새로 생성
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
