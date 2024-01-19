using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _goes = false;

    private GameObject _spawner;

    private void OnEnable()
    {
        Spawn.SpawnerEvent += Move;
    }

    private void OnDisable()
    {
        Spawn.SpawnerEvent -= Move;
    }

    private void Update()
    {
        transform.Translate(_spawner.GetComponent<DirectionMoveEnemy>()._direction * _speed * Time.deltaTime);
    }

    private void Move(GameObject spawner)
    {
        if (!_goes)
        {
            _spawner = spawner;
        }

        _goes = true;
    }
}
