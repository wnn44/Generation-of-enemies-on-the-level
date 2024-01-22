using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Transform _follower;
    [SerializeField] private float _speed;

    // Update is called once per frame
    private void Update()
    {
        // 1- � �������
        //var direction =(_follower.position - transform.position).normalized;
        //transform.forward = direction;

        // 2- � �������
        //transform.LookAt(_follower);

        // 3- � �������  -  � ������� �����������
        transform.position = Vector3.Lerp(transform.position, _follower.position, _speed * Time.deltaTime);
    }
}
