using UnityEngine;
using System;


public class DamageEventArgs : EventArgs
{
    public int Value { get; }
    public string EventName { get; }


    public DamageEventArgs(int value, string eventName)
    {
        Value = value;
        EventName = eventName;
    }
}

public class EventSample4 : MonoBehaviour
{
    public event EventHandler<DamageEventArgs> OnDamaged;

    public void TakeDamege(int value, string eventName)
    {
        OnDamaged?.Invoke(this , new DamageEventArgs(value, eventName));

        Debug.Log($"<color=red>{eventName}�÷��̾ {value}�������� �޾ҽ��ϴ�</color>");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamege(UnityEngine.Random.Range(10, 200), "���� ����");

        }
    }
}
