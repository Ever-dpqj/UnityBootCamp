using UnityEngine;
using UnityEngine.UI;

public class TextScore1 : MonoBehaviour
{
    public Text text;
    public ObjectSpawner spawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = ($"Score : 0\nLevel : 1");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ($"Score : {spawner.Score}\nLevel : {spawner.Level}");
    }
}
