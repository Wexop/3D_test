using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chomper : MonoBehaviour
{

    public Rigidbody rb;

    public float speed;

    public Animator animator;

    public float rotationSpeed;

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
        moveInputVertical = Input.GetAxis("Vertical");
        if (moveInputHorizontal != 0 || moveInputVertical != 0)
        {
            animator.SetBool("isWalking", true);
            Vector3 movementDirection = new Vector3(moveInputHorizontal * speed, rb.velocity.y, moveInputVertical * speed);
            
            Vector3 vectorForRotation = rb.velocity;
            vectorForRotation.y = 0;
            
            rb.velocity = movementDirection;
            Quaternion toRotation = Quaternion.LookRotation(vectorForRotation);
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);


        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }
}
