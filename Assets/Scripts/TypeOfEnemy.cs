using UnityEngine;

public class TypeOfEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _typeEnemy;

    public Enemy TypeEnemy => _typeEnemy;
}
