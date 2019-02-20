using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
    private Animator anime;
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump")) {
            anime.SetTrigger("Flip");
        }
    }
}
