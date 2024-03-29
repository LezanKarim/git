using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingThing : MonoBehaviour
{
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    public float direction = 1;
    private Quaternion startPos;


    void Start()
    {
        startPos = transform.rotation;
    }
    void FixedUpdate()
    {
        Quaternion a = startPos;
        a.x += direction * (delta * Mathf.Sin(Time.time * speed));
        transform.rotation = a;
    }




}
