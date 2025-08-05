using UnityEngine;
//Attribute : [AddComponentMenu("")]처럼 클래스,함수,변수앞에 붙는 []들을 Attribute(속성)이라고함
//에디터의 확장 or 사용자 정의 툴 제작에서 제공되는 기능들
//사용 목적 : 사용자가 에디터를 더 직관적으로, 편의적으로 사용하기 위해

//("그룹이름/기능이름") >> 경로
[AddComponentMenu("Sample/AddComponentMenu")]//메뉴, 기능이름
//그룹을 적을경우 그룹 지정, 아닐경우 기능만 지정.



public class NewMonoBehaviourScript : MonoBehaviour
{
    [ContextMenuItem("메시지 초기화", "MessageReset")]
    public string message = "";

    public void MessageReset()
    {
        message = "";
    }


    [ContextMenu("경고메시지")]

    public void MenuAttributesMethod()
    {
        Debug.LogWarning("경고");
    }
}
