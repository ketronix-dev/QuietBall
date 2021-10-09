using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Ball ball; // Reference to the ball controller.
    public Joystick joystick;
    private Vector3 move;
    // the world-relative desired move direction, calculated from the camForward and user input.
    private Transform cam; // A reference to the main camera in the scenes transform
    private Vector3 camForward; // The current forward direction of the camera
    private bool jump; // whether the jump button is currently pressed
    public const float k_GroundRayLength = 1f;


    private void Awake()
    {
        // Set up the reference.
        ball = this.GetComponent<Ball>();


        // get the transform of the main camera
        if (Camera.main != null)
        {
            cam = Camera.main.transform;
        }
        else
        {
            Debug.LogWarning(
                "Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls.");
            // we use world-relative controls in this case, which may not be what the user wants, but hey, we warned them!
        }
    }


    void Update()
    {
        // Get the axis and jump input.

        float h = joystick.Horizontal;
        float v = joystick.Vertical;
        jump = false;

        // calculate move direction
        if (cam != null)
        {
            // calculate camera relative direction to move:
            camForward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
            move = ((v * camForward + h * cam.right)/2).normalized;
        }
        else
        {
            // we use world-relative directions in the case of no main camera
            move = ((v * Vector3.forward + h * Vector3.right)/2).normalized;
        }
    }
    public void Jump()
    {
        if (Physics.Raycast(this.transform.position, Vector3.down, k_GroundRayLength))
        {
            // ... add force in upwards.
            ball.m_Rigidbody.AddForce(Vector3.up * ball.m_JumpPower, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        // Call the Move function of the ball controller
        ball.Move(move, jump);
        jump = false;
    }
}
