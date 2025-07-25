using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject player;
    //private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    private void LateUpdate()
    {
        Vector3 pos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.position = pos;
    }
}
