using UnityEngine;
//45도 방향으로 이동

public class AngleMove : MonoBehaviour
{
    [SerializeField] float angle_degree;
    [SerializeField] float speed;

    
    // Update is called once per frame
    void Update()
    {
        var radian = Mathf.Deg2Rad * angle_degree;
        Vector3 pos = new Vector3(Mathf.Cos(radian),Mathf.Sin(radian), 0);

        transform.Translate(pos * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Return))
        {
            transform.position = Vector3.zero;
        }

    }
}
