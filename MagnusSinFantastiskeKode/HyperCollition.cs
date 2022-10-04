using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperCollition : MonoBehaviour
{
    public Rigidbody rb;

    private Vector3 previous;
    private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = ((transform.position - previous).magnitude) / Time.deltaTime;
        previous = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("DUSCK");
        Rigidbody body = other.attachedRigidbody;
        body.velocity = rb.velocity;

    }
}
