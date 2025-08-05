using UnityEngine;
using System.Collections;

public class UnitMoveAi : MonoBehaviour
{
    public float speed = 1.0f;
    public float detection = 5.0f; //검색범위

    private Transform player_position;


    void Start()
    {
        player_position = GameObject.FindGameObjectWithTag("Player")?.transform;
        //(? : 널값 가능 >> 오류 방지용)

        if(player_position != null)
        {
            StartCoroutine(Move());
        }
        else
        {
            Debug.LogWarning("플레이어 못찾음");
        }
    }

    IEnumerator Move()
    {
        while (player_position != null)
        {
            float distance = Vector3.Distance(transform.position, player_position.position);

            if (distance <= detection) 
            {
                Vector3 dir = (player_position.position - transform.position).normalized;

                transform.position = Vector3.MoveTowards(transform.position, player_position.position, speed * Time.deltaTime);
            }

            yield return null;
        }
    }
}
