using UnityEngine;

public class SampleSpawner : MonoBehaviour
{
    
    void Start()
    {
        GameObject sample = GameObject.Find("Sample");

        if (sample == null)
        {
            GameObject go = new GameObject("Sample");
            go.AddComponent<Sample>();
        }
        else
        {
            Debug.Log("이미 존재합니다.");
        }   
    }
}
