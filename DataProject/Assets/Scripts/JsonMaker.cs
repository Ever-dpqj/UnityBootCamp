using UnityEngine;
using System;
using System.IO;

public class JsonMaker : MonoBehaviour
{
    [Serializable]
    public class QuestData
    {
        public string quest_name;
        public string reward;
        public string description;
    }

    [Serializable]
    public class QuestList
    {
        public QuestData[] quests;
    }

    private void Start()
    {
        QuestList list = new QuestList()
        {
            quests = new QuestData[] 
            {
            new QuestData () { quest_name = "������ ���̴�.", reward = "exp + 100", description = "�����̶� �ϸ� ���̶� ����." },
            
            new QuestData () { quest_name = "a", reward = "b", description = "c"},

            new QuestData () { quest_name = "d", reward = "e", description = "f"},
            }
        };

        string json = JsonUtility.ToJson(list, true);

        string path = Path.Combine(Application.persistentDataPath, "quests.json");

        File.WriteAllText(path, json);

        Debug.Log("�����");
    }
}
