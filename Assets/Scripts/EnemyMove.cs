using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _differentSpeedsMin;
    [SerializeField] private float _differentSpeedsMax;
    [SerializeField] public Transform Target;

    private float _differentSpeeds;

    private void Start()
    {
        _differentSpeeds = Random.Range(_differentSpeedsMin, _differentSpeedsMax);
    }

    private void Update()
    {
        var direction = (Target.position - transform.position).normalized;
        transform.Translate(direction * _speed * Time.deltaTime * _differentSpeeds);
    }
}
