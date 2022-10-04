using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float forwardSpeed = 10f;
    public float backwardsSpeed = 5f;

    private Rigidbody rigid;

    public float jumpHeight = 10f;
    public bool isGrounded;
    public float feetDist = 0.1f;



    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    void Update()
    {


        //jumping
        if (isGrounded && Input.GetButton("Jump"))
        {
            rigid.AddForce(Vector3.up * jumpHeight);
        }

    }

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, fwd, feetDist))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        
        if (Input.GetKey("d"))
        {
           
            transform.Rotate(transform.rotation.x, 135*Time.deltaTime, transform.rotation.z);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, forwardSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            
            transform.Rotate(transform.rotation.x, -135 * Time.deltaTime, transform.rotation.z);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -backwardsSpeed * Time.deltaTime);
        }


    }

}
