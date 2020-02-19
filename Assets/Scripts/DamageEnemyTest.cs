using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageEnemyTest : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float knockbackForce = 2f;
    public float maxHealth;
    public float currentHealth;
    public float damageTaken;

    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        maxHealth = 10f;
        currentHealth = maxHealth;

        healthBar.value = calculateHealth();

        damageTaken = 2f;
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    public void takeDamage()
    {
        //knockbackEnemy();
        currentHealth -= damageTaken;
        healthBar.value = calculateHealth();
        if(currentHealth <= 0)
        {
            Die();
        }
        else 
        {
            this.gameObject.SetActive(true);
        }

        Debug.Log(this.gameObject.name + " took " + damageTaken + " damage");
    }
    
    void knockbackEnemy()
    {
        //knock enemy back towards the right
        rb2d.velocity = new Vector2(knockbackForce, rb2d.velocity.y);
    }

    float calculateHealth()
    {
        return currentHealth / maxHealth;
    }

    void Die()
    {
        Debug.Log(this.gameObject.name + " died");
        this.gameObject.SetActive(false);
    }
}
