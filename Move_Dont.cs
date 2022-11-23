using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Dont : MonoBehaviour
{
    public float horSpeed = 8f;

    public bool sagabak = true;

    

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        transform.Translate(new Vector2(hor, jump) * horSpeed*Time.deltaTime);

        TurnWay(hor);



       
    }

    private void TurnWay(float hor)
    {
        if (hor > 0 && !sagabak || hor < 0 && sagabak)
        {
            sagabak = !sagabak;

            Vector3 way = transform.localScale;
            way.x *= -1;
            transform.localScale = way;
        }
    }
}
