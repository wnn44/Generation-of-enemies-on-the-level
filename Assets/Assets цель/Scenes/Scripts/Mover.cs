using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var nextPosition = transform.rotation;
        //nextPosition.z = 0;
        transform.Translate(_movementDirection, Space.World);
        //transform.rotation = nextPosition;

    }
}
