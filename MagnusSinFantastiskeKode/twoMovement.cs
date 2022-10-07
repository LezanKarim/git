using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoMovement : MonoBehaviour
{
    public int groundSpeed = 5;
    public int airSpeed = 3;
    public int jumpHeight = 1;

    private Vector3 moveDirection = Vector3.zero;
    private float gravity = 20.0f;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();


        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection *= groundSpeed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpHeight;
            }
        }

        else if (!controller.isGrounded && Mathf.Abs(moveDirection.x) < airSpeed)
        {
            moveDirection.x = Input.GetAxis("Horizontal") * airSpeed;
        }
        //rotating here
        transform.right = Vector3.Slerp(transform.right, Vector3.right * Input.GetAxis("Horizontal"), 0.1f);

        


        moveDirection.y -= gravity* Time.deltaTime;

        moveDirection.z = 0;
             
        controller.Move(moveDirection* Time.deltaTime);
    }
}