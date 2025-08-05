using UnityEngine;

//유니티의 회전

//1. 오일러각에 의한 xyz회전값
//transform의 rotation에 표기된값

//2. 쿼터니언 - 회전을 계산하기에 안정적인 수학적인 방식을 가진 값
//내부에서 실제로 저장되고 계산되는 값


//쿼터니언으로 처리하는 이유
//쿼터 -> 오일러 변환시 360도 이상의 회전은 보정될 수 있음
// 380 -> 20

//짐벌 락 현상(Gimbal Lock) : 2개의 축이 정렬되는 순간, 회전방향이 2개만 남는 현상

//쿼터니언 ->> (x,y,z,w)   |   w : 스칼라
//쿼터니언도 벡터와 같이 방향인 동시에 회전의 개념을 가짐
//세축을 동시에 회전 ->> 짐벌락 현상 발생x
//원점과 방향을 비교해 회전을 측정할 수 있음

//단점 : 180도 이상의 표현 불가 / 직관적이지 않다


public class ObjectRotate : MonoBehaviour
{

    void Start()
    {

        
    }



    void Update()
    {
        //transform.Rotate()는 가장 기본적인 회전 진행 코드
        //(Vector3 eulerAngles) or (float x,float y,float z) or (Vector3 axis, float angle) or (Vector3 axis, float angle, Space.space)

        //오브젝트 기준 회전
        //transform.Rotate(new Vector3(20, 20, 20) * Time.deltaTime);

        //절대좌표 기준 회전
        transform.Rotate(new Vector3(20, 20, 20) * Time.deltaTime, Space.World);
    }
}
