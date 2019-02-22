using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{ 
    public float speed;
    private Rigidbody rb;
    //public Collider door;
    public bool collectedKey = false;

    private void Start()
    {
        //speed = 0.05f;
        rb = GetComponent<Rigidbody>();
        //door = GetComponent<Collider>();
    }


    public void Update()
    {
    
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.transform.Translate(movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            collectedKey = true;
            //door.enabled = !door.enabled;
        }

        //if (other.gameObject.CompareTag("Door"))
        //{
        //    if (collectedKey == true)
        //    {
        //        SceneManager.LoadScene("NextScene");
        //        //Debug.Log("")
        //    }
        //}

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            if (collectedKey == true)
            {
                SceneManager.LoadScene("NextScene");
                //Debug.Log("")
            }
        }
    }

}