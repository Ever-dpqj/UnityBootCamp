using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [Header("Shooting Setting")]
    [Tooltip("ÃÑ¾Ë »ý»ê °øÀå")] public GameObject bulletFactory;
    [Tooltip("ÃÑ±¸")] public GameObject firePosition;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bullet = Instantiate(bulletFactory, firePosition.transform.position, Quaternion.identity);
        }
    }
}
