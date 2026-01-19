using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour
{
    public GameObject whiteItemPrefab;
    public GameObject blackItemPrefab;

    public Vector2 spawnRangeX = new Vector2(-1, 1);
    public Vector2 spawnRangeZ = new Vector2(-1, 1);

    public float minSpawnTime = 5f;
    public float maxSpawnTime = 10f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime);

            SpawnItem();
        }
    }

    void SpawnItem()
    {
        Vector3 pos = new Vector3(
            Random.Range(spawnRangeX.x, spawnRangeX.y),
            1f,
            Random.Range(spawnRangeZ.x, spawnRangeZ.y)
        );

        GameObject prefab =
            Random.value < 0.5f ? whiteItemPrefab : blackItemPrefab;

        Instantiate(prefab, pos, Quaternion.identity);
    }
}
