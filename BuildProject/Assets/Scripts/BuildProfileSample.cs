using System.Collections.Generic;
using UnityEngine;

public class BuildProfileSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

#if CUSTOM_DEBUG_MODE
        Debug.Log("디버그모드");
#elif CUSTOM_RELEASE_MODE
        Debug.Log("릴리스모드");
#endif
    }

    void Update()
    {
        
    }
}