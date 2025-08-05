using UnityEngine;


[ExecuteInEditMode]

public class EditMenuSample : MonoBehaviour
{
    private void Update()
    {
        if (!Application.isPlaying)
        {
            Vector3 pos = transform.position;
            pos.y = 0f;
            transform.position = pos;

            Debug.Log("Editor Test");
        }
    }
}
