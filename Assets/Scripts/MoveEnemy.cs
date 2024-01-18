using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _colliding = false;
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
        if (!_colliding)
        {
            transform.position = Vector3.MoveTowards(transform.position, _spawner.gameObject.transform.Find("CollectionPoint").position, _speed * Time.deltaTime);            
        }

        if (transform.position == _spawner.gameObject.transform.Find("CollectionPoint").position)
        {
            _colliding = true;
        }
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
