using System.Collections.Generic;
using UnityEngine;

public class BuildProfileSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

#if CUSTOM_DEBUG_MODE
        Debug.Log("����׸��");
#elif CUSTOM_RELEASE_MODE
        Debug.Log("���������");
#endif
    }

    void Update()
    {
        
    }
}