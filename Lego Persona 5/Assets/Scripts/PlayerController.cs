using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // List of Variables that affect the Player Movement
    public float moveSpeed;
    public Rigidbody theRB;
    public float jumpForce;
    
    
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // Tells the Player when the input is pressed to move to that area
        theRB.velocity = new Vector3(Input.GetAxis("Vertical") * moveSpeed, theRB.velocity.y, Input.GetAxis("Horizontal") * moveSpeed);
    
        if(Input.GetButtonDown("Jump")) 
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce, theRB.velocity.z);
        
        }
    
    }
}
