using UnityEngine;
//Mathf -> 수학관련 유틸리티 클래스
//ex)Mathf.Abs(-5);

//정적메소드 : static으로 구성 / 클래스명.메소드명으로 사용 가능


public class MathfSample : MonoBehaviour
{
    float abs =  -5;
    float ceil = 4.1f;
    float floor = 4.6f;
    float round = 4.5f;
    float clamp;
    float clamp1;
    float pow = 1111;
    float sqrt = 100;


    void Start()
    {
        Debug.Log(Mathf.Abs(abs));//절댓값(absolute number)
        Debug.Log(Mathf.Ceil(ceil));//올림
        Debug.Log(Mathf.Floor(floor));//내림
        Debug.Log(Mathf.Round(round));//반올림
        Debug.Log(Mathf.Clamp(7, 0, 4));//값, 최소, 최대 -> 값 최소값or최댓값 제한
        Debug.Log(Mathf.Clamp01(5));//현재 받은 값 = 5 / 최소=0, 최대=1 / 퍼센트 값 처리할때 유용
        //Clamp >> 체력, 점수, 속도 제한
        //Clamp01 >> 비율(퍼센트), 보간값, 알파값(투명도) 

        Debug.Log(Mathf.Pow(pow, 2));//제곱 / 값, 지수
        Debug.Log(Mathf.Sqrt(sqrt));//루트
    }

    void Update()
    {
        
    }
}
