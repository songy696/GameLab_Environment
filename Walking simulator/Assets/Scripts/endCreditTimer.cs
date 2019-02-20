using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class endCreditTimer : MonoBehaviour
{
    public Animator animator;

    public int waitForSeconds;

    public int waitForSecondsAfter;

    public string nextScene;

    private void Update()
    {
        fadeToLevel();
    }

    public void fadeToLevel()
    {
        StartCoroutine(loadAfterDelay(nextScene));
    }

    IEnumerator loadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(waitForSeconds);
        animator.SetTrigger("fadeOut");
        yield return new WaitForSeconds(waitForSecondsAfter);
        SceneManager.LoadScene(levelName);
        Debug.Log("CHOO CHOO MOVING TO NEXT SCENE");
    }
}
