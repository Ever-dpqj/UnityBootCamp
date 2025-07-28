using UnityEngine;
//오브젝트 캐싱에 대해
//캐시 : 자주사용되는 데이터를 미리 복사해두는 임시 장소

//시간 지역성 : 가장 최근 값이 다시 사용될 가능성이 높다
//공간 지역성 : 최근에 접근한 주소와 인접한 주소가 다시 ''

public class Sample3 : MonoBehaviour
{

    Rigidbody rb;
    Vector3 pos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    //캐싱
    }

    void Update()
    {
        rb.AddForce(pos*5);
    }
}
