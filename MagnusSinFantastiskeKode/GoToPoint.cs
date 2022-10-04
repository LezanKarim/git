using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GoToPoint : MonoBehaviour
{

    public Transform Target;
    public float RotationSpeed;
    public float Speed;
    public int num = 0;
    public int level = 1;

    //values for internal use
    private Quaternion _lookRotation;
    private Vector3 _direction;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 3 * Speed);
        //find the vector pointing from our position to the target
        _direction = (Target.position - transform.position).normalized;

        //create the rotation we need to be in to look at the target
        _lookRotation = Quaternion.LookRotation(_direction);

        //rotate us over time according to speed until we are in the required rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("rotet");
        if (other.gameObject.tag == "Point")
        {
           
            
            if(other.gameObject.name == (" (" + (num.ToString()) + ")"))
            {
                
                if (GameObject.Find("Level"+level.ToString()).transform.childCount == num +1 )
                {
                    Debug.Log("CUFk");
                    num = 0;
                    Target = GameObject.Find("Level" + level.ToString()).transform.GetChild(num).transform;
                }
                else
                {
                    num++;
                    Target = GameObject.Find("Level" + level.ToString()).transform.GetChild(num).transform;
                }
                Debug.Log(GameObject.Find("Level" + level.ToString()).transform.childCount);

                
                //Speed = other.gameObject.GetComponent<Point>().Speed;
            }

            
        }
        level = Convert.ToInt32(GameObject.Find("Body").GetComponent<Respawn>().Checkpoint.name);
        //level = GameObject.Find("Body").GetComponent<Respawn>().Checkpoint.name.ToInt32();
    }
}
