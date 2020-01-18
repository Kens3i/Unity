using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public Ball ball;
    public GameObject FirstPersonCharacter;

    public float ballDistance = 2f;
    public float ballThrow = 5f;

    public bool holdingBall = true;
    // Start is called before the first frame update
    void Start()
    {
        ball.GetComponent<Rigidbody>().useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = FirstPersonCharacter.transform.position + FirstPersonCharacter.transform.forward * ballDistance;

            if(Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ball.ActiveTrail();
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(FirstPersonCharacter.transform.forward * ballThrow);
            }
        }
    }
}
