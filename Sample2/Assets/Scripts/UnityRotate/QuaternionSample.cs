using UnityEngine;

//쿼터니언 기능 정리
//Quarternion.identity = 회전없음
//Quarternion.Enler(x,y,z) = 오일러각변환
//Quarternion.AngleAxis(angle, axis) 특정 축 기준 회전
//Quarternion.LookRotation(forward, upward) 해당 방향을 바라보는 회전상태 반환

//forward : 회전 시점 방향
//Upward : 방향을 바라보고 있을때의 위부분을 설정(기본값은 up이라 특별한경우가 아니라면 건들x)

//회전값 적용
//transform.rotation = Quarternion.Euler(x,y,z) : 현재 오브젝트의 회전값을 적용합니다.

//회전에 대한 보간
//Quarternion.Slerp(from, to, t) 구면 선형 보간
//Quarternion.lerp(form, to, t) 선형 보간
//Quarternion.RotateTowards(from, to, maxDegree) 일정각도만큼 점진적으로 회전

//1.LookAt(target):추가 회전 보간이나 제어가 어렵고, 설정값을 기준으로 transforem.rotation을 자동세팅
//2.LookRotation(direction)의 경우는 회전값만 계산하고 직접적인 계산적용은 x
//-->계산은 끝, 추가적인작업으로 계산처리 ㄱㄱ


public class QuaternionSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
