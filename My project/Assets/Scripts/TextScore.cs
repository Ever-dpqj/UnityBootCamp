using UnityEngine;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{
    public Text text;
    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = ("Score : 0");
    }
    void LateUpdate()
    {
        text.text = ($"Score : {playerController.score}");
        if(playerController.score > 100)
        {
            text.text = ($"Score : {playerController.score}\nÅ¬¸®¾î!");

        }
    }
}

