using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    float sprint;
    Rigidbody2D playerRB;
    public float speed;
    public float jumpForce;
    public bool grounded = false;
    public bool crouched = false;
    public BoxCollider2D collider;


    StatsManager statsManager;

    
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        statsManager = gameObject.GetComponent<StatsManager>();
    }


    void FixedUpdate()
    {
        LeftAndRight();

        Run();

        Jump();

        Face();
    }

    void LeftAndRight()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed * sprint;
    }

    void Face()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void Run()
    {
        if(Input.GetKey(KeyCode.LeftShift) && statsManager.Stamina > 0)
        {
            sprint = statsManager.Agility + 1;
        }
        else if (!Input.GetKey(KeyCode.LeftShift) || statsManager.Stamina <= 0)
        {
            sprint = 1;
        }

        
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.W) && grounded == true && crouched == false)
        {
            playerRB.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.S))
        {
            crouched = true;
            collider.isTrigger = true;
            sprint = 0.5f;
        }
        else
        {
            crouched = false;
            collider.isTrigger = false;
        }
    }


    void OnCollisionStay2D(Collision2D coll)
    {
        if(coll.collider.tag == "ground")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.collider.tag == "ground")
        {
            grounded = false;
        }
    }
}
