using UnityEngine;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{
    public Text text;
    public PlayerController playerController;
    private float time=0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = ("Score : 0");
    }
    void Update()
    {
        if (playerController.score>0 && playerController.score<101)
        {
            time += Time.deltaTime;
        }

        string time_text = string.Format("{0:N1}", time);
        text.text = ($"Score : {playerController.score}\t\tTime : {time_text}");
        if(playerController.score > 100)
        {
            text.text = ($"Score : {playerController.score}\t\tTime : {time_text}\nÅ¬¸®¾î!");
        }
    }
}

