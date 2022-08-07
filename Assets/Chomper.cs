using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chomper : MonoBehaviour
{

    public Rigidbody rb;

    public float speed;

    private float moveInputHorizontal;
    private float moveInputVertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        moveInputHorizontal = Input.GetAxis("Horizontal");
        if (moveInputHorizontal != 0)
        {
            rb.velocity = new Vector3(moveInputHorizontal * speed, rb.velocity.y, rb.velocity.z);
            
        }
        
        moveInputVertical = Input.GetAxis("Vertical");
        if (moveInputVertical != 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, moveInputVertical * speed);
        }
    }
}
