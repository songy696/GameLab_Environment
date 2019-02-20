using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Script : MonoBehaviour
{
    public Light[] coralLights;
    //public Light cl;

    void Start()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            Debug.Log("hit");


            for (int i = 0; i < coralLights.Length; i++)
            {
                StartCoroutine(FadeIn(coralLights[i]));

            }
            //StartCoroutine("FadeIn");
        }
    }

    IEnumerator FadeIn(Light cl)
    {

        while (cl.intensity < 18f)
       {
        yield return new WaitForSeconds(.2f);
        cl.intensity += 1.65f;
       
        }

    }

}
