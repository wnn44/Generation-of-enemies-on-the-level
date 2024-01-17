using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _colliding = false;
    [SerializeField] private bool _goes = false;

    private Vector3 _position;

    private void OnEnable()
    {
        Spawn.SpawnPoint += Move;
    }

    private void OnDisable()
    {
        Spawn.SpawnPoint -= Move;
    }

    private void Update()
    {
        if (!_colliding)
        {
            transform.position = Vector3.MoveTowards(transform.position, _position, _speed * Time.deltaTime);
        }

        if(transform.position == _position)
        {
            _colliding = true;
        }
    }

    private void Move(Vector3 positionCollectionPoint)
    {
        if (!_goes)
        {
            _position = positionCollectionPoint;
        }

        _goes = true;
    }
}
