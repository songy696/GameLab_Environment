using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;

    public int speed = 20;
    public int jumpForce = 800;

    private Vector2 rotation = Vector2.zero;
    public float rotSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //new Vector3(0,0,0); = Vector3.zero; these two work same
    }

    // Update is called once per frame
    void Update()
    {
        //GetAxisRaw - no decimal number and no smooth movement like GetAxis

        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += Input.GetAxis("Mouse Y");
        transform.eulerAngles = rotation * rotSpeed;
        //eulerAngles = typecast around 0 to 360

        //Vector3 move = Input.GetAxis("Vertical") * transform.forward * speed;
        //Vector3 strafe = Input.GetAxis("Horizontal") * transform.right * speed;
        //rb.velocity = move; //+strafe;

        float xSpeed = Input.GetAxis("Horizontal") * speed;
        float zSpeed = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector3(xSpeed, rb.velocity.y, zSpeed); 


        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }

    }
}
