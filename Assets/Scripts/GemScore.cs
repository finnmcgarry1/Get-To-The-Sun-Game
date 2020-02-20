using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "Player")
        {
            GameScore.AddScore(1000);
            this.gameObject.SetActive(false);
        }

    }
    
     
}
