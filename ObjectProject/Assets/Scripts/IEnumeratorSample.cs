using UnityEngine;
using System.Collections;

public class IEnumeratorSample : MonoBehaviour
{
    class CustomCollection : IEnumerable
    {
        int[] numbers = { 6, 7, 8, 9, 10 };


        //numbers 배열 순회하는 IEnumerator 형태의 객체로 변환
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return numbers[i];
            }
        }
    }

    int[] numbers = { 1, 2, 3, 4, 5 };

    void Start()
    {
        //numbers 배열 순회하는 IEnumerator 형태의 데이터로 변환
        IEnumerator enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current);
        }//다음값이 없을때까지 반복

        CustomCollection collection = new CustomCollection();

        //foreach는 순환 가능한 데이터를 순차적으로 작업할 때 사용하는 for문
        foreach (int number in collection)
        {
            Debug.Log(number);
        }

        IEnumeratorSample isample = new IEnumeratorSample();

        

        foreach (var message in GetMessage())
        {
            Debug.Log(message);
        }
    }



    //yield는 한번에 하나씩 값을 넘기고 메소드가 일시정지되며, 후속값들을 지속적으로 반환하게 합니다.
    //(반복작업, 순차적인 데이터 처리에 사용)
    //yield return , yield break 로 사용
    //ㄴ 값 반환과 동시에 일시중지 -> 다음값을 요구할때까지
    //ㄴㄴ 반복 종료하는 코드
    //장점: 필요할때까지 계산을 미룸(메모리 효율, 큰데이터 처리 이점)

    //IEnumerable : 반복가능한 컬렉션을 나타내는 인터페이스
    //ㄴ 이 기능을 구현한 클래스는 반복가능 객체가 되고, 순차적 탐색이 가능해짐
    //ㄴㄴ 사용하기 위해서 GetEnumerator() 메소드를 구현해야함

    //IEnumerator : 반복을 관리하는 인터페이스
    //ㄴ 컬렉션에서 항목을 반환, 상태를 관리하는 역할 수행
    //ㄴㄴ MoveNext(): 다음값접근, Current: 현재값 확인, Reset(): 리셋


    static IEnumerable GetMessage()
    {
        Debug.Log("메소드 시작");
        yield return "야";
        Debug.Log("돌아옴1");
        yield return "호";
        Debug.Log("돌아옴2");
        yield break;
        //작업종료

        ////접근불가 
        //Debug.Log("3");
        //yield return "!";
    
    }
}

