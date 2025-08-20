using System;
using UnityEngine;

public class EventSample2 : MonoBehaviour
{
    void Start()
    {
        EventSample eventSample = GetComponent<EventSample>();
        eventSample.OnSpaceEnter += OnSpaceButton;
    }

    private void OnSpaceButton(object sender, EventArgs e)
    {
        Debug.Log("<color=blue>Sample에서 등록한 기능</color>");
    }
}
/////////////////////////////////////////

