using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightSwitch : MonoBehaviour
{

    public Light[] roomlights;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //print("hi");
            for (int i = 0; i < roomlights.Length; i++){
                //roomlights[i].enabled = false;
                StartCoroutine(Flicker(roomlights[i]));
                //StartCoroutine(Fade(roomlights[i]));
            }
        }
    }

    IEnumerator Fade(Light rl)
    {
        while(rl.intensity <0){
            yield return new WaitForSeconds(.1f);
            rl.intensity -= 1f;
            print(rl.intensity);
        }

    }

    IEnumerator Flicker(Light rl){
        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;

        yield return new WaitForSeconds(.1f);
        rl.intensity = 1;

        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;

        yield return new WaitForSeconds(.1f);
        rl.intensity = 1;

        yield return new WaitForSeconds(.1f);
        rl.intensity = 0;

        yield return new WaitForSeconds(.1f);
        rl.intensity = 0.5f;

        SceneManager.LoadSceneAsync("CuteLand"); //delete all the back scenes 
    }
}
