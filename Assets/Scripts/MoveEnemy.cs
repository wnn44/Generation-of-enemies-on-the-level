using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    public Transform _target;

    private float _differentSpeeds;

    private void Start()
    {
        _differentSpeeds = Random.Range(1, 3);
    }

    private void Update()
    {
        var direction = (_target.position - transform.position).normalized;
        transform.Translate(direction * _speed * Time.deltaTime * _differentSpeeds);
    }
}
