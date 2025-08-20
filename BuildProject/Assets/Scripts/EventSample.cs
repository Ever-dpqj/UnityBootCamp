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
            //int? : Nullable ��Ÿ��, �ΰ� ���
            //Ÿ�� �����

            //?. : Null ���� ������
            //Null���̸� ���� ����
            //�޼ҵ�, �Ӽ�, �̺�Ʈ ���� ȣ���
        }
    }
    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow>����Ű�Է�</color>");
    }
}
