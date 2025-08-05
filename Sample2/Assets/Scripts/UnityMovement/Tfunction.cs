using UnityEngine;
//1 라디안 = 약 57도

public class Tfunction : MonoBehaviour
{
    //요약
    //Sin(Radian) : 주어진각의 Y좌표
    //Cos(Radian) : 주어진각의 X좌표
    //Tan(Radian) : 주어진각의 기울기( y/x )

     public void CircleRotate()
    {
        float angle = Time.time * 90.0f;
        float radian = angle * Mathf.Deg2Rad;

        var x = Mathf.Cos(radian) * 5.0f;
        var y = Mathf.Sin(radian) * 5.0f;

        transform.position = new Vector3(x, y, 0);
    }


    public void ButterFly()
    {
        float t = Time.time * 2.0f;
        float x = Mathf.Sin(t) * 2;
        float y = Mathf.Sin(t * 2.0f) * 2 * 2;

        transform.position = new Vector3(x, y, 0);
    }

    //Time.time : 시작이후 시간
    //Time.deltatime : 프레임마다의 시간
    public void Wave()
    {
        var offset = Mathf.Sin(Time.time * 2.0f) * 0.5f;
        transform.position = pos + Vector3.up * offset;
    }

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            CircleRotate();
        }
        if (Input.GetMouseButton(1))
        {
            Wave();
        }
        if (Input.GetMouseButton(2))
        {
            ButterFly();    
        }
    }
}
