using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;

    public float xBound;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1));
        Instantiate(enemy, new Vector3(Random.Range(-xBound, xBound), transform.position.y, transform.position.z), Quaternion.identity);
        StartCoroutine(SpawnEnemy());

    }
}
