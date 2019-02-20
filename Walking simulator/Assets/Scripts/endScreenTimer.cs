using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreenTimer : MonoBehaviour
{
    public Animator animator;

    public int waitForSecondsBeforeFade;

    public int waitForSecondsAfterFade;

    public string nextScene;

    public AudioSource lostCity;
    public AudioSource endSong;

    bool canStart;
    
    void Start()
    {
        //fadeToLevel(1);
        canStart = true;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canStart == true)
        {
           
            Debug.Log("ending sequence start");

            if (lostCity.volume > 0.1) {
                lostCity.volume--;
            }
            canStart = false;
            endSong.Play();
            fadeToLevel(1);

        }
    }

    public void fadeToLevel(int levelIndex)
    {
        StartCoroutine(loadAfterDelay(nextScene));
    }

    IEnumerator loadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(waitForSecondsBeforeFade);
        animator.SetTrigger("fadeOut3");
        yield return new WaitForSeconds(waitForSecondsAfterFade);
        SceneManager.LoadScene(levelName);
    }
}
