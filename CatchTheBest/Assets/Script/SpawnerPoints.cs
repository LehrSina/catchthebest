using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{
    /*
        * https://www.youtube.com/watch?v=WGn1zvLSndk&t=2s    
    */


    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    private int rand;

    void Start()
    {
        StartCoroutine(Spawner());

    }

    
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

        IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, 2);

            //die neue spawn position wird berechnet mit einem neuen Vektor. Random Werte der spawnvalue Variable werden in spawnPosition gespeichert
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
 