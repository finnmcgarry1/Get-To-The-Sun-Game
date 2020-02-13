using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigid2d;

    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rigid2d.freezeRotation = true;
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        rigid2d.velocity = new Vector2(speed * move, rigid2d.velocity.y);


    }
}
