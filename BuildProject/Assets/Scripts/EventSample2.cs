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
        Debug.Log("<color=blue>Sample���� ����� ���</color>");
    }
}
/////////////////////////////////////////

