//HannahGuerin 2023.9.12
//Script for basic camera ans first person controls


//Libraries we are using
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonController : MonoBehaviour
{

    //Player Variables
    public float speed = 2f; //This is snail pace
    public float gravity = -10f;
    public float jumpForce = 2f;

    //Movement and Looking
    private CharacterController characterController;
    private Vector2 moveImput;
    private Vector3 playerVelosity;
    private bool grounded;
    private Vector2 mouseMovement;

    //Camera Variables
    public Camera cameraLive;
    public float sensitivity = 25f;
    private float camXRotation;


    // Start is called before the first frame update
    void Start()
    {
      
        characterController = GetComponent<CharacterController>();

        //Hides the mouse cursor at start
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        grounded = characterController.isGrounded;
        MovePlayer();
        Look();
    }

    public void MovePlayer()
    {
       //Direction to move
        Vector3 moveVec = transform.right * moveImput.x + transform.forward * moveImput.y;

        //Move Controloler
        characterController.Move(moveVec * speed * Time.deltaTime);

        //Add Gravity
        playerVelosity.y += gravity * Time.deltaTime;

         if (grounded && playerVelosity.y < 0) {
                     playerVelosity.y = -2.5f; 
        }

            characterController.Move(playerVelosity * Time.deltaTime);
    }

    public void Look()
    {
        float xAmount = mouseMovement.y * sensitivity * Time.deltaTime;
        float yAmount = mouseMovement.x * sensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * mouseMovement.x * sensitivity * Time.deltaTime);

        camXRotation -= xAmount;
        camXRotation = Mathf.Clamp(camXRotation, -90f, 90f);

        //Sets camera's local rotation. Player will be able to look up and down. Might have to play with these settings.

        cameraLive.transform.localRotation = Quaternion.Euler(camXRotation, 0, 0);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
       
        moveImput = context.ReadValue<Vector2>();
        Debug.Log("Move Imput Value: " + moveImput.ToString()); 

    }
    public void OnLook(InputAction.CallbackContext context)
    {

        mouseMovement = context.ReadValue<Vector2>();
        Debug.Log("Mouse Movement: " + mouseMovement.ToString());

    }
    public void OnJump(InputAction.CallbackContext context) 
    {

        Jump();
        Debug.Log("Jumped");
    }


    public void Jump()
    {
        if (grounded) 
        {
            playerVelosity.y = jumpForce;
        }
    }

}
