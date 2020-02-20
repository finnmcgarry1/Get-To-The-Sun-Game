using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScore : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "Player")
        {
            GameScore.AddScore(100);
            this.gameObject.SetActive(false);
        }

    }
}
