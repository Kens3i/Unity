using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float fwd;
    public float side;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(fwd,0,0 );

        if (Input.GetKey("a")) 
        {
            rb.AddForce(0,0,side,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -side, ForceMode.VelocityChange);
        }
        if(rb.position.y<-2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
