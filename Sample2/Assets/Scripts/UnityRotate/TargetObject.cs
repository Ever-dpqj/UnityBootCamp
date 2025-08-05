using UnityEngine;

//목표 방향으로 회전시키는 코드

public class TargetObject : MonoBehaviour
{

    public Transform target;

    public float speed = 90.0f; //초당 회전속도




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //특정방향을 바라보는 회전
        var targetRotation = Quaternion.LookRotation(target.position - transform.position);
        
        //(위치, 타겟위치, 속도)
        //현재회전에서 타겟의회전으로 부드럽게 회전진행
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
