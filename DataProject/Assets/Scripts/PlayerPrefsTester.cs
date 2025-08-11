using UnityEngine;

public class PlayerPrefsTester : MonoBehaviour
{
    public int score;
    public int maxscore = 10;

    private void Start()
    {
        score = PlayerPrefs.GetInt("score", 1);
        PlayerPrefs.SetInt("MaxScore", maxscore);

        PlayerPrefs.Save();
            
        //Debug.Log();
        Debug.Log(PlayerPrefs.GetInt("MaxScore"));
    }

    private void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
