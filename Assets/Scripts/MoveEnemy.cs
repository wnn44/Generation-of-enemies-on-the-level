using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var direction = (_goalBeingPursued.position - transform.position).normalized;
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
