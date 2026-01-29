using UnityEngine;

public class PlayerScirpt : MonoBehaviour
{
    public float jumpSpeed = 1.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float velocity = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            transform.Translate(Vector3.up * jumpSpeed);
        }
        if (Input.GetKey("d"))
        {
            moveDirection = Vector3.right;
        }
        else if (Input.GetKey("a"))
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKey("w"))
        {
            moveDirection = Vector3.forward;
        }
        else if (Input.GetKey("s"))
        {
            moveDirection = Vector3.back;
        }
        else {             moveDirection = Vector3.zero;
        }

        transform.Translate(moveDirection * velocity * Time.deltaTime);
    }


    
}
