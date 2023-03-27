using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D box;
    
    public float xspeed;
    public Rigidbody2D box1;
    public Rigidbody2D box2; 
    // Start is called before the first frame update
    public float m_Speed = 5f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        box1= GetComponent<Rigidbody2D>();
        box2= GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Store user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), xspeed, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        // box.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }
}
