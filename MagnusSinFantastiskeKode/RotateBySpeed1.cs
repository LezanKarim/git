using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBySpeed1 : MonoBehaviour
{
    public float speed;
    Vector3 oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;
        //Debug.Log("Speed: " + speed.ToString("F2"));

        transform.Rotate(0, 0, (((100 + speed*10) * Time.deltaTime))* -2);
    }
}
