using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject RangedEnemyPrefab;

    [SerializeField] public float x1 = 0;
    [SerializeField] public float x2 = 0;
    [SerializeField] public float y1 = 0;
    [SerializeField] public float y2 = 0;

    [SerializeField] public int SpawnAmounts = 0;

    [SerializeField] public float SpawnInterval = 0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }
    IEnumerator spawnEnemy()

    {
        int retrySpawn = 0;
        while (retrySpawn < SpawnAmounts)
        {
            float x = Random.Range(x1, x2);
            float y = Random.Range(y1, y2);
            Vector2 enemyPos = new Vector2(x, y);

            Collider2D CollisionWithEnemy = Physics2D.OverlapCircle(enemyPos, 1f, LayerMask.GetMask("Default","playerShip","Asteroids","BlackHole"));
            if (CollisionWithEnemy == false)

            {
                GameObject newEnemy = Instantiate(RangedEnemyPrefab, enemyPos, transform.rotation);
            }

            else
            {
                Debug.Log("can't spawn here" );
            }
            retrySpawn++;
            yield return new WaitForSecondsRealtime(SpawnInterval);
        }
    }
}