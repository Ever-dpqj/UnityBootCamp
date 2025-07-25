using UnityEngine;

public class SkeletonController : MonoBehaviour
{
    public GameObject Skeleton;
    public void OnLButtonEnter()
    {
        Skeleton.transform.Translate(1, 0, 0);
    }
    public void OnRButtonEnter()
    {
        Skeleton.transform.Translate(-1, 0, 0);

    }
}
