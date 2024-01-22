using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBeingPursued : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoints = 0;

    // Update is called once per frame
    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoints].position)
        {
            _currentWaypoints = (_currentWaypoints + 1) % _waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoints].position, _speed * Time.deltaTime);

    }
}
