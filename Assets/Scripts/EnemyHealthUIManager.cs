using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthUIManager : MonoBehaviour
{
    public Slider health;
    public Text healthDesc;

    public float hideHUDtime;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        hideHUDtime += Time.deltaTime;

        if(health.value <= 0)
        {
            health.enabled = false;
            healthDesc.enabled = false;
        }
        else
        {
           health.enabled = true;
           healthDesc.enabled = true; 
        }
    }
}
