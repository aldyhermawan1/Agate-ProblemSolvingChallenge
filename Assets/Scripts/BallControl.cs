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

        //Problem 2 & 3
        //Invoke("PushBall", 1); 
    }

    private void Update()
    {
        //Problem 4 Start
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = transform.position;
            position.y += 0.5f;
            transform.position = position;
        } 
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = transform.position;
            position.x -= 0.5f;
            transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = transform.position;
            position.x += 0.5f;
            transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = transform.position;
            position.y -= 0.5f;
            transform.position = position;
        }
        //Problem 4 End
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
