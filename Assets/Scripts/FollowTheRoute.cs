using UnityEngine;

public class FollowTheRoute : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoints = 0;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoints].position)
        {
            _currentWaypoints = (_currentWaypoints + 1) % _waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoints].position, _speed * Time.deltaTime);
    }
}
