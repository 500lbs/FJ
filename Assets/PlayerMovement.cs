using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float gravity = -9.81f;

    Vector3 velocity;

<<<<<<< Updated upstream:Assets/PlayerMovement.cs
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

=======
     public Transform groundCheck;
     public float groundDistance = 0.4f;
     public LayerMask groundMask;
     bool isGrounded;
     
     public int bugCounter = 0;

     public float speed = 1.25f;
>>>>>>> Stashed changes:Assets/Scripts/PlayerMovement.cs
    public float jumpHeight = 3f;
    
    void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
<<<<<<< Updated upstream:Assets/PlayerMovement.cs
=======

>>>>>>> Stashed changes:Assets/Scripts/PlayerMovement.cs
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            controller.SimpleMove(forward * 3);
        }

<<<<<<< Updated upstream:Assets/PlayerMovement.cs
=======
        
>>>>>>> Stashed changes:Assets/Scripts/PlayerMovement.cs
        if(Input.GetKey("space") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
<<<<<<< Updated upstream:Assets/PlayerMovement.cs

=======
        
    }
    
    private void OnTriggerEnter(Collider other) //makes bug disappear when found
    {
        if (other.transform.CompareTag("Bug"))
        {
            bugCounter++;
            Destroy(other.gameObject); 
        }
>>>>>>> Stashed changes:Assets/Scripts/PlayerMovement.cs
    }
}
