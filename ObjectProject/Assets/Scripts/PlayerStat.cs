using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public UnitSpawner spawner;
    public int hp = 100;
    public int score = 0;
    public int wave = 1;

    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<UnitSpawner>();
    }
    public void Hit()
    {
        hp -= 10;
    }

    public void ScoreUp()
    {
        if (hp > 0)
        {
            score += 10;
            wave = score / 500 + 1;
            if (score % 500 == 0)
            {
                spawner.NextWave();
            }
        }
    }
}
