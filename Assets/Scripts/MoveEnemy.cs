using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    //public Vector3 pointToGo;
    public float speed;

    public bool colliding = false;

    private void Update()
    {
        if (!colliding)
        {
            //Move
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _gameObject.gameObject.transform.position, step);
            //Debug.Log(transform.position);
        }
    }

    //Callback when enter the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        colliding = true;

    }

}
