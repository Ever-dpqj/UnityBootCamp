using UnityEngine;

//�Ѿ� ����
public class Fire : MonoBehaviour
{
    public BulletPool pool;
    public Transform pos; //�߻�����

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
