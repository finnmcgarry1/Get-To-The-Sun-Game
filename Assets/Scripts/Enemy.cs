using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float knockbackForce = 2f;
    public GameObject fbar, hbar, ebar;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        health = 2;
        fbar.gameObject.SetActive(true);
        hbar.gameObject.SetActive(false);
        ebar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (health > 2)
        {
            health = 2;
        }

        switch (health)
        {
            case 2:
                fbar.gameObject.SetActive(true);
                hbar.gameObject.SetActive(false);
                ebar.gameObject.SetActive(false);
                break;

            case 1:
                fbar.gameObject.SetActive(false);
                hbar.gameObject.SetActive(true);
                ebar.gameObject.SetActive(false);
                break;
            case 0:
                Debug.Log(this.gameObject.name + "died");
                fbar.gameObject.SetActive(false);
                hbar.gameObject.SetActive(false);
                ebar.gameObject.SetActive(true);
                break;
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
