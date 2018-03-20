using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speedNum;

    //Character Controller
    private CharacterController controller;
    private float verticalVelocity;
    private float gravity = 10.0f;
    private float jumpForce = 5.0f;

    //Rigid Body 
    public Rigidbody rb;

    public float multiplier;

    //Game object 
    public GameObject ball;

    //Check for respawn
    private bool belowground;
    

    // Use this for initialization
    void Start()
    {
        belowground = false;

        //Initializing rigid body and char controller @ the start
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //Respawn function
        if (ball.transform.position.y < 0)
        {
            belowground = true;
        }

        if (belowground == true)
        {
            ball.transform.position = new Vector3(-2, 5, -8);
            belowground = false;
        }

        /*
        //VARIABLES
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        //Ball Movement
        Vector3 movement = new Vector3(xSpeed, 0, ySpeed);
        rb.AddForce(movement * speedNum);
        */

        //Alternate moving script
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //Moving and jumping 
        Vector3 moveVector = Vector3.zero;

        moveVector.x = Input.GetAxis("Horizontal") * 5.0f;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxis("Vertical") * 5.0f;
        controller.Move(moveVector * Time.deltaTime);

    }
}