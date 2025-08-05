using System;
using UnityEngine;
//Raycast : ������ ������ ��� �浹�� ������Ʈ�� �ִ��� �Ǵ�
//1) Ư��������Ʈ�� �浹�������� ���ܰ���
//2) Ư��������Ʈ�� ���� �浹������ Ȯ���ϴ� �뵵


public class RayCastSample : MonoBehaviour
{
    RaycastHit hit; //�浹������ ����

    //physics.RayCast(Vector3 origin, Vector3 direction, out RayCastHit hitInfo, float maxDistance, int layerMask);

    //hitInfo �� �浹ü�� ����

    const float length = 20.0f;

    void Start()
    {
        
    }



    void Update()
    {

        Debug.DrawRay(transform.position, transform.forward * length, Color.red);
         
        int ignoreLayer = LayerMask.NameToLayer("Red");//�浹 ����

        int layerMask = ~(1 << ignoreLayer);//��Ʈ ����

        if (Physics.Raycast(transform.position, transform.forward, out hit, length, layerMask))
        {
            Debug.Log("asdf");
            hit.collider.gameObject.SetActive(false);
        }
    }
}
