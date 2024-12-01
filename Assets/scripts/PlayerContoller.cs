using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerContoller : MonoBehaviour
{
    public float movespeed = 4f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    private GameObject attackArea = default;

    private bool attacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;

    private int damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
        

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetMouseButtonDown(0) && !attacking)
        {
            Attack();
            StartCoroutine(AttackAnimationRoutine());
        }
        if(attacking)
        {
            timer += Time.deltaTime;
            if(timer >= timeToAttack)
            {


            }
        }


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
    private void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }

    IEnumerator AttackAnimationRoutine()
    {
        animator.SetBool("isAttacking", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isAttacking", false);
        timer = 0f;
        attacking = false;
        attackArea.SetActive(attacking);
    }

}
