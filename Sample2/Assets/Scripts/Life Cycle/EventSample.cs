using UnityEngine;

public class EventSample : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("단 한 번만 / 해당 스크립트가 비활성화되어 있어도 실행 / 코루틴으로 실행 불가능");
        Debug.Log("각 스크립트 기준 한번만 호출이 되고 다른 개체의 초기화가 완료 된 후 호출되는 영역이기 때문에" +
            "다른 컴포넌트에 대한 참조를 만들어야하는 경우 이 위치에서 만들면 안전");
    //코루틴 : 코드를 일시중지하고 특정 조건이 충족될 때 까지 실행을 delay 시킬수 있는 기능(ex. 3초 뒤에 오브젝트를 파괴.)

    }

    private void OnEnable()
    {
        Debug.Log("해당위치는 오브젝트나 스크립트가 활성화될때 호출 / 온오프가 빈번한 경우");
    }
    void Start()
    {
        Debug.Log("awake 이후 실행 / 코루틴 실행 가능");     
    }

//공통점 : 값에 대한 초기화를 수행하는 위치
//상황에 따라 설계
//Awake : 변수 초기화 / 값 참조
//Start : 게임 로직 실행 / 초기화된 데이터를 기반으로 작업 수행 / 코루틴 작업

    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        //물리계산, 일정한 발생주기(rigidbody)
        // Fixed TimeStep 가 설정된 주기로 호출됨
    }

    private void LateUpdate()
    {
        //모든 update 이후
    }
}
