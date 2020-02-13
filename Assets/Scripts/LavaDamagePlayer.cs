using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamagePlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {

        print(col);
            GameLogicScript.health--;
        
    }
}