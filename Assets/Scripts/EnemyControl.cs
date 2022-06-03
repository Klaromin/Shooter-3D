using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float Radius = 1;
    [SerializeField] List<GameObject> enemyList = new List<GameObject>();
    public GameObject enemyPrefab;
    public int waveNumber = 0;
    public int enemyDifficulty = 0;
    public int enemySpawnAmount = 3;
    public int enemiesKilled = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartWave();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (enemiesKilled >= enemySpawnAmount)
        {
            NextWave();
        }

    }

    public void SpawnEnemyAtRandom()
    {




            Vector3 randomPos = new Vector3(Random.Range(-38, 38), 2.2f, Random.Range(-38, 38));
            Instantiate(enemyList[enemyDifficulty], randomPos, Quaternion.identity);
        




    }

    public void StartWave()
    {
        waveNumber = 1;
        enemyDifficulty = 0;
        enemySpawnAmount = 3;
        enemiesKilled = 0;
        for(int i =0; i < enemySpawnAmount; i++)
        {
            SpawnEnemyAtRandom();
            
        }
        enemyDifficulty++;
    }

    public void NextWave()
    {
        waveNumber++;
        enemyDifficulty++;
        enemiesKilled = 0;
        for (int i = 0; i < enemySpawnAmount; i++)
        {
            SpawnEnemyAtRandom();

        }
    }









    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
