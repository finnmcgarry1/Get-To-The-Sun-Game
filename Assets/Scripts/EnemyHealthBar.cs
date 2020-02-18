using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject fbar, hbar, ebar;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
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
                fbar.gameObject.SetActive(false);
                hbar.gameObject.SetActive(false);
                ebar.gameObject.SetActive(true);
                break;
        }
    }
}
