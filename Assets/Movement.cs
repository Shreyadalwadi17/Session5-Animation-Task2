using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] Joystick joystick;
    public Animator pa;
    public Animator cy1;
    public Animator cy;
    public Animator anjump;
    public Rigidbody rb;
    Vector3 direction;
    float hinput;
    float vinput;
    float speed = 2f;
    public float helth = 3;
    public GameObject Player;

    private void FixedUpdate()
    {
        MoveJoyStick();
        MoveAnimation();



        if (Input.GetKey(KeyCode.Space))
        {
            pa.SetTrigger("jump");
        }
        if (Input.GetKey(KeyCode.A))
        {
            pa.SetTrigger("attack");
        }
        if (Input.GetKey(KeyCode.P))
        {
            pa.SetTrigger("punch");
        }
    }



    void MoveJoyStick()
    {
        hinput = joystick.Horizontal;
        vinput = joystick.Vertical;
        direction = Vector3.left * hinput + Vector3.forward * vinput * -1;
        rb.velocity = new Vector3((direction * speed).x, rb.velocity.y, (direction * speed).z);
    }

    private void MoveAnimation()
    {
        pa.SetFloat("hinput", hinput);
        pa.SetFloat("vinput", vinput);
    }
    void Cyanimation()
    {
        cy1.SetTrigger("cy");
        cy.SetTrigger("cy");

    }
    void Anjump()
    {
        anjump.SetTrigger("anjump");
    }

    public void Jumpbtn()
    {
        pa.SetTrigger("jump");
    }


    public void Attackbtn()
    {

        pa.SetTrigger("attack");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            //helth -= 1;
            //Debug.Log("Life" + helth);
            //if (helth == 0)
            //{
            Destroy(collision.gameObject);
            //}

        }
    }


}