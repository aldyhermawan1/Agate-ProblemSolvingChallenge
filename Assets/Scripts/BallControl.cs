using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speedX;
    public float speedY;

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ResetBall();
        Invoke("PushBall", 1);
    }


    private void ResetBall()
    {
        transform.position = Vector2.zero;
        rb2d.velocity = Vector2.zero;
    }

    private void PushBall()
    {
        rb2d.AddForce(new Vector2(speedX, speedY));
    }
}
