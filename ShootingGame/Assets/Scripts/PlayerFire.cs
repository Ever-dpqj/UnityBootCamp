using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [Header("Shooting Setting")]
    [Tooltip("�Ѿ� ���� ����")] public GameObject bulletFactory;
    [Tooltip("�ѱ�")] public GameObject firePosition;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bullet = Instantiate(bulletFactory, firePosition.transform.position, Quaternion.identity);
        }
    }
}
