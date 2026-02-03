using UnityEngine;

public class PlayerScirpt : MonoBehaviour
{
    public float jumpSpeed = 1.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float velocity = 10.0f;
    public Rigidbody rb;
    public float speedMultiplier = 1.0f;
    public Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Camera.main.transform.eulerAngles.y
        transform.rotation = Quaternion.Euler(0, 0, 0);

        //shift run
        if(Input.GetKeyDown("left shift"))
        {
            speedMultiplier = 1.5f;
        }
        if(Input.GetKeyUp("left shift"))
        {
            speedMultiplier = 1.0f;
        }

        //jump
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }

        //wasd movement
        if (Input.GetKey("d"))
        {
            moveDirection = Vector3.right;
        }
        else if (Input.GetKey("a"))
        {
            moveDirection = Vector3.left ;
        }
        else if (Input.GetKey("w"))
        {
            moveDirection = Vector3.forward;
        }
        else if (Input.GetKey("s"))
        {
            moveDirection = Vector3.back;
        }
        else {             
            moveDirection = Vector3.zero;
        }

        //rotation

        if (0.0f<Input.mousePositionDelta.x) 
        { 
        
        }

        transform.Translate(moveDirection * velocity * speedMultiplier * Time.deltaTime);
    }


    
}
