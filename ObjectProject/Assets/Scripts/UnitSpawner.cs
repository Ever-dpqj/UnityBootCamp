using System.Collections;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public GameObject unitPrefab;
    public Transform spawnPoint;
    public float interval;
    public float random;

    private void Start()
    {
        interval = 1.5f;
        StartCoroutine(Spawn());
    }

    public void NextWave()
    {
        interval *= 0.5f;
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(interval);

        while (true)
        {            
            Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity);

            random = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(interval*random);
        }
    }
}
