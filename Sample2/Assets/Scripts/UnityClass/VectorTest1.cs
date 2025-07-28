using UnityEngine;

public class VectorTest1 : MonoBehaviour
{
    public Transform A_Cube;
    public Transform B_Cube; 


    void Start()
    {
        Vector3 posA = A_Cube.position;
        Vector3 posB = B_Cube.position;

        Vector3 BtoA = posB - posA;
        Vector3 AtoB = posA - posB;
        
        float distance = Vector3.Distance(posA, posB);
        //Distance() -> 3차원에서의 점점 거리공식
        Debug.Log(distance);
    }

    void Update()
    {
        
    }
}
