using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Flicker : MonoBehaviour
{

    public Light[] coralLights;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            Debug.Log("hit");


            for (int i = 0; i < coralLights.Length; i++)
            {
                StartCoroutine(Flicker(coralLights[i]));

            }
            
        }
    }

    IEnumerator Flicker(Light cl)
    {

        
            yield return new WaitForSeconds(.1f);
            cl.intensity += 2.5f;
            yield return new WaitForSeconds(.1f);
            cl.intensity -= 2.0f;
            yield return new WaitForSeconds(.1f);
            cl.intensity += 2.5f;
            yield return new WaitForSeconds(.1f);
            cl.intensity -= 2.0f;
        yield return new WaitForSeconds(.1f);
        cl.intensity += 2.5f;
        yield return new WaitForSeconds(.1f);
        cl.intensity -= 2.0f;
        yield return new WaitForSeconds(.1f);
        cl.intensity += 3f;
        yield return new WaitForSeconds(.1f);
        cl.intensity -= 1.5f;



    }

}
