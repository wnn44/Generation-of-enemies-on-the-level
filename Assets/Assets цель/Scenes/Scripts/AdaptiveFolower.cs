using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AdaptiveFolower : MonoBehaviour
{
    //protected override void Move()
    //{
    //    transform.position = Vector3.Lerp(Transform.position, Target, Speed);
    //}

    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;

    // Update is called once per frame
    private void Update()
    {
        //var direction = (_player.position - transform.position).normalized;
        //transform.Translate(direction * _speed);

        transform.position = Vector3.Lerp(transform.position, _player.position, _speed);
    }
}
