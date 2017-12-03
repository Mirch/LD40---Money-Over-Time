using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public GameObject DestinationObject;

    private Vector3 Destination;
    public float Speed;

    private Vector3 StartPosition;


    void Start()
    {
        StartPosition = transform.position;
        Destination = DestinationObject.transform.position;
    }

    void Update()
    {
        transform.position = MoveTowardsDestination(transform);
        if (transform.position.Equals(Destination)) Turn();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Destination")) Turn();
    }

    private void Turn()
    {
        Vector3 aux = StartPosition;
        StartPosition = Destination;
        Destination = aux;
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.parent = null;
        }
    }

    Vector3 MoveTowardsDestination(Transform transform)
    {
        return Vector3.MoveTowards(transform.position, Destination, Speed * Time.deltaTime);
    }

}