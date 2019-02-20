using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{
    public AudioSource aud;

    public AudioClip dash;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            //aud.Play();
            aud.PlayOneShot(dash); //play when press button and it plays only once.
            //print("play");
        }
    }
}
