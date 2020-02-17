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

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "Player")
        {
            IsDamageLava = true;
        }

    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.collider.tag == "Untagged")
        {
            IsDamageLava = false;
        }
    }
}