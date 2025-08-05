using System;
using UnityEngine;
//Raycast : 가상의 광선을 쏘고 충돌한 오브젝트가 있는지 판단
//1) 특정오브젝트를 충돌범위에서 제외가능
//2) 특정오브젝트에 대한 충돌판정을 확인하는 용도


public class RayCastSample : MonoBehaviour
{
    RaycastHit hit; //충돌감지용 변수

    //physics.RayCast(Vector3 origin, Vector3 direction, out RayCastHit hitInfo, float maxDistance, int layerMask);

    //hitInfo 는 충돌체의 정보

    const float length = 20.0f;

    void Start()
    {
        
    }



    void Update()
    {

        Debug.DrawRay(transform.position, transform.forward * length, Color.red);
         
        int ignoreLayer = LayerMask.NameToLayer("Red");//충돌 ㄴㄴ

        int layerMask = ~(1 << ignoreLayer);//비트 반전

        if (Physics.Raycast(transform.position, transform.forward, out hit, length, layerMask))
        {
            Debug.Log("asdf");
            hit.collider.gameObject.SetActive(false);
        }
    }
}
