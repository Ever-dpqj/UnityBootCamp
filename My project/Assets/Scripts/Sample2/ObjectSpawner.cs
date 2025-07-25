using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefeb;

    float spawnTime = 2.0f;
    float time = 0.0f;
    public int Score;
    public int Level = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > spawnTime)
        {
            time = 0.0f;
            GameObject FallingObject = Instantiate(objectPrefeb);

            int rand = Random.Range(-9, 9);
            FallingObject.transform.position = new Vector3(rand, 7, 0);
        }

        Level = Score / 500 + 1;
        
    }
    public void ScoreUp()
    {
        Score += 50;
    }
    public void ScoreDown()
    {
        Score -= 50;
    }
}
