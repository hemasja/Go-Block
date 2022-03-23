using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backwardForce = 1000f;
    void Start()
    {
        

    }

    // Update is called once per frame

    //We are using "fixed"Update because we are using it to mess with physics.
    void FixedUpdate() 
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -backwardForce * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
                                                                                      
    }
}
