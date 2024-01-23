using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private List<SpawnPoint> _spawnList = new List<SpawnPoint>();
    [SerializeField] private int _spawnTime;
    [SerializeField] private int _numberEnemies;

    private Enemy _enemy;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (_numberEnemies > 0)
        {
            SpawnNewEnemy();

            yield return new WaitForSeconds(_spawnTime);

            --_numberEnemies;
        }
    }

    private void SpawnNewEnemy()
    {
        int numberSpawner = UnityEngine.Random.Range(0, _spawnList.Count);

        SpawnPoint spawnPoint = _spawnList[numberSpawner];
        Vector3  positionSpawnPoint = spawnPoint.gameObject.transform.position;
        Enemy enemy = spawnPoint.GetComponent<TypeOfEnemy>().TypeEnemy;
        Transform target = spawnPoint.GetComponent<Target>().GoalBeingPursued;

        Instantiate(enemy, positionSpawnPoint, Quaternion.identity).GetComponent<EnemyMove>().Target = target;
    }
}

