using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeisChecked : MonoBehaviour
{
    public float distance = 5;
    float duration = 5.0f;
    public LayerMask playerLayer;
    public bool playerInRange;
    private AudioSource aud;
    float startTime = 1.0f;


    void Start() {
        aud = GetComponent<AudioSource>();
        startTime = Time.time;
    }

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, distance, playerLayer);

        if (hitColliders.Length > 0)
        {
            Mathf.SmoothStep(aud.volume,0,t);
            aud.volume = 100;

            //if (aud.volume > 100)
            //{
            //    aud.volume++;
            //}
        }
        else
        {
            if (aud.volume > 0)
            {
                aud.volume--;
            }
        }
    }
}
