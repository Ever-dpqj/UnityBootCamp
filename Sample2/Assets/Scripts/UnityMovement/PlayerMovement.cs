using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumppower;
    public LayerMask ground;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3 (x, 0, z);

        Vector3 velocity = dir * speed;

        rb.linearVelocity = velocity;
        //리지드바디의 속성
        //linear : 선형 속도
        //angular : 각 속도

        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
            //Impulse : 순간적인 힘
            //Force : 지속적인 힘
        }
    }


    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.51f, ground);
    }
}
