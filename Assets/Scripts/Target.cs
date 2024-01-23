using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _goalBeingPursued;

    public Transform GoalBeingPursued => _goalBeingPursued;
}
