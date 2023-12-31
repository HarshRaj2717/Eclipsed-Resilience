using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexMovement : MonoBehaviour
{
    public float alexSpeed = 10f;
    private Rigidbody2D alexBody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        alexBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");
        alexBody.rotation = 0;
        alexBody.velocity = new Vector2(dirX * alexSpeed, dirY * alexSpeed);

        if (dirX != 0)
        {
            if (dirX > 0f)
                animator.SetInteger("movement", 2);
            else
                animator.SetInteger("movement", 4);
        }
        else if (dirY != 0)
        {
            if (dirY > 0f)
                animator.SetInteger("movement", 1);
            else
                animator.SetInteger("movement", 3);
        }
        else
        {
            animator.SetInteger("movement", 0);
        }
    }
}
