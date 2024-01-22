using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _speed;
   
    void Start()
    {
        _offset = transform.position - _player.position;
    }

    void Update()
    {
        Vector3 LenRay;

        transform.position = _offset + _player.position;

        transform.RotateAround(_player.position, Vector3.up, _speed);

        transform.LookAt(_target.position);
        _offset = transform.position - _player.position;

        LenRay = _target.position - transform.position;
        Debug.DrawRay(transform.position, LenRay, Color.red);
    }
}
