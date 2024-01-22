using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFolower : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    // Update is called once per frame
    private void Update()
    {
        var direction = (_player.position - transform.position).normalized;
        transform.Translate(direction * _speed);
    }
}
