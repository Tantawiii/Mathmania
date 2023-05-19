using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner1 : MonoBehaviour
{   
    [SerializeField]private GameObject Enemy;
    [SerializeField]private GameObject Enemy2;
    [SerializeField]private GameObject Enemy3;

    [SerializeField]private float EnemyTime = 5.5f;
    [SerializeField]private float EnemyTime2 = 3.5f;
    [SerializeField]private float EnemyTime3 = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(EnemyTime,Enemy));
        StartCoroutine(spawnEnemy(EnemyTime2,Enemy2));
        StartCoroutine(spawnEnemy(EnemyTime3,Enemy3));
    }

    private IEnumerator spawnEnemy(float timeInterval, GameObject enemy)
    {
        yield return new WaitForSeconds(timeInterval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(6.85f,8.05f), Random.Range(-1.6f,2.5f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(timeInterval,enemy));
    }
}
