using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    public float agroRange;

    [SerializeField]
    public float speed;

    Rigidbody2D rigid2d;

    public Animator animator;


    CircleCollider2D col;
    bool IsAttack = false;
    

    // Update is called once per frame
    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        //distance to the player
        float distancePlayer = Vector2.Distance(transform.position, player.position);


        animator.SetFloat("Speed", speed);

        if(distancePlayer < agroRange)
        {
            //chase code
            ChasePlayer();
        }
        else if(distancePlayer > agroRange)
        {
            //stop chasing player
            EndChasePlayer();
        }
        else if((distancePlayer <= 1))
        {
            AttackPlayer();
        }

        if(IsAttack == true)
        {
            OnTriggerEnter2D(col);
        }
       
    }

    void AttackPlayer()
    {
        
    }

    void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            //moves right
            rigid2d.velocity = new Vector2(speed, rigid2d.velocity.y);
            transform.localScale = new Vector2(1, 1);
        }
        else if (transform.position.x > player.position.x)
        {
            //moves left
            rigid2d.velocity = new Vector2(-speed, rigid2d.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }
    }

    void EndChasePlayer()
    {
        rigid2d.velocity = new Vector2(0, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        IsAttack = true;
        switch (col.tag)
        {

            case "Ground":
                rigid2d.AddForce(Vector2.up * 350f);
                break;
        }
    }
}
