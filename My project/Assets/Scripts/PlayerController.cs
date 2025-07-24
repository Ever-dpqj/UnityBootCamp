using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int obstacle_num=60;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody>();
        Debug.Log("dddd");
    }

    // Update is called once per frame
    void Update()
    {   

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movemont = new Vector3(horizontal, 0, vertical);

        rb.AddForce(movemont * speed);

        if (obstacle_num == 0)
        {
            Debug.Log("Ŭ����");
            obstacle_num--;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ItemBox"))
        {
            Debug.Log("������ ȹ��");
            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("�浹");
            other.gameObject.SetActive(false);
            obstacle_num--;
        }
    }
}
