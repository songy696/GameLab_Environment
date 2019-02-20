using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class animationTrigger : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            fadeToLevel(1);
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        animator.SetTrigger("play");
    }
}
