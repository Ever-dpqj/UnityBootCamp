using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text text;
    public GameObject Player;
    public PlayerStat playerstat;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerstat = Player.GetComponent<PlayerStat>();
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ("Wave : " + playerstat.wave + "  HP : " + playerstat.hp + "\nScore : " + playerstat.score);
        if (playerstat.hp <= 0)
        {
            text.text = ("Your Score : " + playerstat.score + "\nGAME OVER");
        }
    }
}
