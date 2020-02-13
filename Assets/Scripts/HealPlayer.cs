using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameLogicScript.health += 1;
    }
}
