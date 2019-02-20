using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneTrigger : MonoBehaviour
{
    public Animator animator;

    public int waitForSeconds;

    public string nextScene;
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            fadeToLevel(1);
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        animator.SetTrigger("fadeOut");
        StartCoroutine(loadAfterDelay(nextScene));
    }

    IEnumerator loadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(waitForSeconds);
        SceneManager.LoadScene(levelName);
        Debug.Log("CHOO CHOO MOVING TO NEXT SCENE");
    }
}
