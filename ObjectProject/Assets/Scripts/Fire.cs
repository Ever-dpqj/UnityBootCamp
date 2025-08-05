using UnityEngine;

//총알 생성
public class Fire : MonoBehaviour
{
    public BulletPool pool;
    public Transform pos; //발사지점

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = pool.GetBullet();
            bullet.transform.position = pos.position;
            bullet.transform.rotation = pos.rotation;
        }
    }
}
