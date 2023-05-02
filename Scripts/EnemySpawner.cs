using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
public GameObject enemyPrefab;
    public float reloadTime = 1f;
    public float spawnDistance = 13;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        GameObject Enemy = Instantiate(enemyPrefab);
        Enemy.transform.position = new Vector3(
            Random.Range(transform.position.x - spawnDistance, transform.position.x + spawnDistance),
            transform.position.y,
            0
            );
        yield return new WaitForSeconds(reloadTime);
        StartCoroutine(Spawn());
    } 
}
