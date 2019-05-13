using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    Transform playerTransform;
    public float turnSpeed;
    public float movementSpeed = 5;
    Rigidbody rb;

    bool contrInvert;
    bool aleatory;

    private void Awake()
    {
        playerTransform = this.transform;
        rb = GetComponent<Rigidbody>();
        contrInvert = false;
        aleatory = false;
    }

    void Update()
    {
        
        rb.velocity = Vector3.zero;
        Vector3 direction = Vector3.zero;



        if (!contrInvert && !aleatory)
        {
            
            if (Input.GetKey(KeyCode.W))

                direction += transform.forward;

            if (Input.GetKey(KeyCode.S))
                direction -= transform.forward;

            if (Input.GetKey(KeyCode.A))
                direction -= transform.right;

            if (Input.GetKey(KeyCode.D))
                direction += transform.right;

        }else if(contrInvert && !aleatory)
        {
            
            if (Input.GetKey(KeyCode.W))

                direction -= transform.forward;

            if (Input.GetKey(KeyCode.S))
                direction += transform.forward;

            if (Input.GetKey(KeyCode.A))
                direction += transform.right;

            if (Input.GetKey(KeyCode.D))
                direction -= transform.right;

        }else if(aleatory && contrInvert)
        {
            if (Input.GetKey(KeyCode.UpArrow))

                direction -= transform.forward;

            if (Input.GetKey(KeyCode.DownArrow))
                direction += transform.forward;

            if (Input.GetKey(KeyCode.RightArrow))
                direction += transform.right;

            if (Input.GetKey(KeyCode.LeftArrow))
                direction -= transform.right;

        }else if (aleatory && !contrInvert)
        {
            if (Input.GetKey(KeyCode.UpArrow))

                direction += transform.forward;

            if (Input.GetKey(KeyCode.DownArrow))
                direction -= transform.forward;

            if (Input.GetKey(KeyCode.RightArrow))
                direction -= transform.right;

            if (Input.GetKey(KeyCode.LeftArrow))
                direction += transform.right;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if(Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
            }else {
                Time.timeScale = 0f;
            }
        }
            
            direction = direction.normalized;
            rb.MovePosition(transform.position + direction * Time.deltaTime * movementSpeed);  
    }

    public Vector3 GetVelocity()
    {
        return rb.velocity;
    }

    public float GetMaxVelocity()
    {
        return movementSpeed;
    }

    public Vector3 GetPosition()
    {
        return rb.position;
    }

    public void changeVelocity(float a)
    {
        if (movementSpeed + a <= 0)
        {
            movementSpeed = 0.5f;
        }
        else if (movementSpeed >= 5.5f)
        {
            movementSpeed = 5;
        }
        else
        {
            movementSpeed = movementSpeed + a;
        }
   
    }

    public void invertControls()
    {
        
        contrInvert = !contrInvert;
    }

    public void FlechaControl()
    {
        aleatory = !aleatory;
    }
}
