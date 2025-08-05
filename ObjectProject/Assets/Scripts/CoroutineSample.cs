using UnityEngine;
using System.Collections;


public class CoroutineSample : MonoBehaviour
{
    //적용할 타겟
    public GameObject target;

    //변화 시간
    float duration = 5.0f;

    //색
    public Color color;

    void Start()
    {
        //타겟이 설정되어 있다면
        if(target != null)
        {
            StartCoroutine(ChangeColor());
            //해당 메소드 IEnumerator 형태의 메소드를 코루틴으로 시작
            //코드작성과정에서 메소드 결정되어 안전함
            //호출하기때문에 문자열을 찾는것보다 빠름

            //StartCoroutine("ChangeColor");
            ////문자열을 통해 매개변수없는 코루틴 호출가능
            //타입체크 하지않아서 잘못된 이름 쓰면 런타임오류발생
        }
        else
        {
            Debug.LogWarning("현재 타겟 등록x");
        }

    }

    IEnumerator ChangeColor()
    {
        var targetRenderer = target.GetComponent<Renderer>();

        if (targetRenderer == null)
        {
            Debug.LogWarning("렌더러를 얻어오지못함");
            yield break;
        }

        float time = 0.0f;
        var start = targetRenderer.material.color;
        var end = color;

        //반복작업
        //코루틴 반복문설계는 yield에 의해 나갓다가 돌아와서 반복문실행
        while (time < duration)
        {
            time += Time.deltaTime;
            var value = Mathf.PingPong(time, duration) / duration;
            //Mathf.PingPong(a,b)
            //>> a,b사이에서 반복되는 값을 생성(왕복운동)
            //정규화작업을 진행한이유 -> color >> 0~1사이의 값

            targetRenderer.material.color = Color.Lerp(start, end, value);

            yield return null;
        }

    }
}
