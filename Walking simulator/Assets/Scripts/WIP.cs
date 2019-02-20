using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIP : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //GetInput();
        StartCoroutine(waiter());

        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        AnimateMovement(direction);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sceneTrigger")
        {
            speed = 0;
        }
    }

    private void GetInput()
    {

        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }

    public void AnimateMovement(Vector2 direction)
    {
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0);
        GetInput();
    }
}
