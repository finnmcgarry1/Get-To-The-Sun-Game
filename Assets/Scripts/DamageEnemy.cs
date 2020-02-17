using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public int health = 10;
    public float knockbackForce = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log(this.gameObject.name + " died");
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage)
    {
        //knockbackEnemy();
        health -= damage;
        Debug.Log("Damage taken: -" + damage + " health");
    }

    void knockbackEnemy()
    {
        //knock enemy back towards the right
        rb2d.velocity = new Vector2(knockbackForce, rb2d.velocity.y);
    }
}
