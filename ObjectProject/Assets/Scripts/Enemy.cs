using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Me;
    public GameObject Player;
    public GameObject effect_prefab;
    public PlayerStat playerstat;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerstat = Player.GetComponent<PlayerStat>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == Player)
        {
            playerstat.Hit();

            if (effect_prefab != null)
            {
                Instantiate(effect_prefab, transform.position, Quaternion.identity);
            }

            Destroy(Me);
        }
        if (collider.gameObject.tag == "Bullet")
        {
            playerstat.ScoreUp();
            Destroy(Me);
        }
    }
}
