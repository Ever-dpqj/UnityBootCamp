using UnityEngine;
//Mathf 상수값.



public class MathfConstant : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Mathf.PI);//3.1415926535
        Debug.Log(Mathf.Infinity);//무한대
        Debug.Log(Mathf.NegativeInfinity);//음의무한대
        //ex) 나누기0
        //ex) float 범위보다 큰수의 제곱(float.MaxValue)
        Debug.Log(Mathf.Sqrt(-1));//NaN(Not a Naumber)
        //using System.Numveriics;
        //Complex c= Complex.Sqrt(-1);
        //단점) WebGL등 사용이 제한되는 경우가 있음


        //NaN
        //1. NaN끼리의 비교 불가능( == 불가능)
        // -->> float.IsNaN() 사용하기
        Vector3 pos = transform.position;
        if (float.IsNaN(pos.x))
        {
            pos = Vector3.zero;
        }

        // 그 이외의 값
        // Mathf.Deg2Rad() : Degree을 라디안으로
        // Mathf.Rad2Deg() : 라디안을 각으로
        // Mathf.Epsilon : float 에서 0에 가장 가까운 0이 아닌 양수값





    }
}
