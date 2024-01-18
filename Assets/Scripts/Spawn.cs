using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnList = new List<GameObject>();
    [SerializeField] private int _spawnTime;
    [SerializeField] private GameObject _spawnPrefab;
    [SerializeField] private int _numberEnemies;

    public static event Action<GameObject> SpawnerEvent;

    private Vector3 _positionSpawnPoint;

    private void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
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
        
        _positionSpawnPoint = _spawnList[numberSpawner].gameObject.transform.position;
        Instantiate(_spawnPrefab, _positionSpawnPoint, Quaternion.identity);

        SpawnerEvent?.Invoke(_spawnList[numberSpawner]);
    }
}
