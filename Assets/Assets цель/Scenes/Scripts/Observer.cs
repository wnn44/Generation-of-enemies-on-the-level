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
        // 1- й вариант
        //var direction =(_follower.position - transform.position).normalized;
        //transform.forward = direction;

        // 2- й вариант
        //transform.LookAt(_follower);

        // 3- й вариант  -  с плавным замедлением
        transform.position = Vector3.Lerp(transform.position, _follower.position, _speed * Time.deltaTime);
    }
}
