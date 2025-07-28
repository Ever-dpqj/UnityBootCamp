using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float falling_speed;
    public GameObject player;
    public ObjectSpawner spawner;
    public int Score;
    public int Level;


    void Start()
    {
        player = GameObject.Find("Player");
        spawner = GameObject.Find("ObjectSpawner").GetComponent<ObjectSpawner>();
        falling_speed = 2.5f;
        Score = spawner.Score;
        Level = spawner.Level;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -falling_speed*Time.deltaTime, 0);

        if(transform.position.y < -1)
        {
            Destroy(gameObject);
            spawner.ScoreUp();
        }
        Vector3 v1 = transform.position;
        Vector3 v2 = player.transform.position;
        Vector3 dir = v1 - v2;

        float d = dir.magnitude;

        float obj_r1 = 0.5f;
        float obj_r2 = 1.2f;

        if (d <obj_r1 + obj_r2)
        {
            Destroy(gameObject);
            spawner.ScoreDown();
        }
        falling_speed = 2.5f + Level*2;
        
    }
}
