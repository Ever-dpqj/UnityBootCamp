using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LookPlayer : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Quaternion rotation = Quaternion.LookRotation(Player.transform.position - transform.position);
        transform.rotation = rotation;
        transform.Rotate(0, -90, 0);
    }
}
