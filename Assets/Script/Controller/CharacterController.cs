using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator anim;

    public float speedFrw;
    public float speed2;
    private bool isMoving = false;

    void Start()
    {
        if (!rb)
        {
            rb = GetComponent<Rigidbody>();
        }
        if (!anim)
        {
            anim = GetComponent<Animator>();
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetTrigger("Run");

            Vector3 movement = transform.forward * speedFrw;
            rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
            isMoving = true;
        }
        else
        {
            anim.SetTrigger("Idle");
            isMoving = false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetTrigger("Squad");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 movement = -transform.right * speed2;
            rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 movement = transform.right * speed2;
            rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
        }
    }

}

