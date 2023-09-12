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
    public float speed = 2f;
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
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        
    }
    public void OnLook(InputAction.CallbackContext context)
    {

    }
    public void OnJump(InputAction.CallbackContext context) 
    {
    
    }


}
