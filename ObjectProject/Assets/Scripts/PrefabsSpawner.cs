using UnityEngine;

public class PrefabsSpawner : MonoBehaviour
{
    public GameObject prefab;
    private GameObject spawned;
    public float delay = 3.0f;


    void Start()
    {
        if (prefab != null)
        {
            spawned = Instantiate(prefab);
            //오버로드
            //(prefab) : 해당프리팹정보에 따라 생성
            //(prefab, transform.position, Quaternion,identity) : 설정된 위치와 회전값에따라 생성
            //(prefab, parent) : 오브젝트를 부모의 자식의 위치에 생성
            //(prefab, transform.position, Quaternion,identity, parent) : 짬뽕

            spawned.name = "생성된오브젝트";

            Debug.Log(spawned.name + "이 생성되었습니다.");

            Destroy(spawned, delay);    
        }
        else
        {
            Debug.LogWarning("등록된 프리팹이 없습니다.");
        }
    }
}
