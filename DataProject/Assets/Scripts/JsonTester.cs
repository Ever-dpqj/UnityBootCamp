using System;
using UnityEngine;
using UnityEngine.UIElements;


public class JsonTester : MonoBehaviour
{
    [Serializable]

    public class Data
    {
        public int hp;
        public int atk;
        public int def;
        public string[] items;
        public Position position;
        public string quest;
        public bool isDead;
        public float x;
        public float y;
    }

    public Data my_data;
    void Start()
    {
        var jsonText = Resources.Load<TextAsset>("data01");
        if(jsonText == null)
        {
            Debug.LogError("¿¡·¯");
            return;
        }

        my_data = JsonUtility.FromJson<Data>(jsonText.text);

        Debug.Log($"{my_data.hp},{my_data.atk},{my_data.def}");


    }
}
