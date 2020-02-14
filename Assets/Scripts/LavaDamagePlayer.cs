using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamagePlayer : MonoBehaviour
{
    bool IsDamageLava = false;

    private void Start()
    {
        InvokeRepeating("Damage", 1.0f, 1f);
    }

    void Damage()
    {
        if (IsDamageLava == true)
        {
            GameLogicScript.health--;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        switch (col.tag)
        {
            case "Player":
                IsDamageLava = true;
                break;

            default:
                IsDamageLava = false;
                break;
        }

    }
}