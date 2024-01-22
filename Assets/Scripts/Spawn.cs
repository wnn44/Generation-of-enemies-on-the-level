using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnList = new List<GameObject>();
    [SerializeField] private int _spawnTime;
    [SerializeField] private int _numberEnemies;

    private Vector3 _positionSpawnPoint;

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

        _positionSpawnPoint = _spawnList[numberSpawner].gameObject.transform.position;
        Instantiate(_spawnList[numberSpawner].GetComponent<TypeOfEnemy>()._typeEnemy, _positionSpawnPoint, Quaternion.identity).GetComponent<MoveEnemy>()._target = _spawnList[numberSpawner].GetComponent<Target>()._goalBeingPursued;
    }
}

