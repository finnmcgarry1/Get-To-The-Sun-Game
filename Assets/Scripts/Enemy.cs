using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float knockbackForce = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        EnemyHealthBar.health = 2;
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    public void takeDamage(int damage)
    {
        //knockbackEnemy();
        EnemyHealthBar.health -= damage;
        Debug.Log("Damage taken: -" + damage + " health");
    }
    
    void knockbackEnemy()
    {
        //knock enemy back towards the right
        rb2d.velocity = new Vector2(knockbackForce, rb2d.velocity.y);
    }
}
