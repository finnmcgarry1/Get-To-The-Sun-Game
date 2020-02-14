using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    bool IsDamage = false;

    private void Start()
    {
        InvokeRepeating("Damage", 1f, 1f);
    }

    void Damage()
    {
        if (IsDamage == true)
        {
            GameLogicScript.health--;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Player":
                IsDamage = true;
                break;

            
        }
    }
}
