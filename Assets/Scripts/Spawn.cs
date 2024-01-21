using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnList = new List<GameObject>();
    [SerializeField] private int _spawnTime;
    [SerializeField] private GameObject _spawnPrefab;
    [SerializeField] private int _numberEnemies;

    private Vector3 _positionSpawnPoint;

    private GameObject _enemy;

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

        _positionSpawnPoint = _spawnList[numberSpawner].gameObject.transform.position;
        _enemy = Instantiate(_spawnPrefab, _positionSpawnPoint, Quaternion.identity);

        Vector3 direction = _spawnList[numberSpawner].GetComponent<DirectionMoveEnemy>()._direction;
        SetDirection(direction);
    }

    private void SetDirection(Vector3 direction)
    {
        _enemy.transform.LookAt(direction);
    }
}

