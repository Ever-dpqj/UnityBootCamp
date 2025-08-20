using UnityEngine;
using System;

public class EventSample : MonoBehaviour
{
    public event EventHandler OnSpaceEnter;

    private void Start()
    {
        OnSpaceEnter += Debug_OnSpaceEnter;   
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(OnSpaceEnter != null)
            {
                OnSpaceEnter(this, EventArgs.Empty);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpaceEnter?.Invoke(this, EventArgs.Empty);
            //int? : Nullable 값타입, 널값 허용
            //타입 선언시

            //?. : Null 조건 연산자
            //Null값이면 실행 안함
            //메소드, 속성, 이벤트 등의 호출시
        }
    }
    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow>엔터키입력</color>");
    }
}
