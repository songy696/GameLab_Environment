using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl2 : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 7.5f;  // ! VARIABLE FOR MOVING FORWARD + BACK SPEED !

    private float yForce = 1000f; // ! VARIABLE FOR MOVING UP + DOWN SPEED !

    private float rotSpeed = 5f;

    private Vector2 rotation = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.visible = false;
    }

    void Update()
    {
        StartCoroutine(waiter());
    }

    void playerMove()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x -= Input.GetAxis("Mouse Y");
        transform.eulerAngles = rotation * rotSpeed;

        Vector3 move = Input.GetAxis("Vertical") * transform.forward * speed;
        Vector3 strafe = Input.GetAxis("Horizontal") * transform.right * speed;

        //Debug.Log("Vector3 strafe" + strafe);

        rb.velocity = move + strafe;

        if (Input.GetButton("moveUp"))
        {
            rb.AddForce(new Vector3(0, yForce, 0));
        }

        if (Input.GetButton("moveDown"))
        {
            rb.AddForce(new Vector3(0, -yForce, 0));
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "sceneTrigger")
        {
            //speed = 0;
            //yForce = 0;
            //rotSpeed = 0;
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        playerMove();
    }
}
