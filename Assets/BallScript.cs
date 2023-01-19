using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 direction;
    private Vector2 originalPos;

    public float ballSpeed = 200.0f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        originalPos = rb2d.position;
        ResetPosition();
    }

    public void StartForce()
    {
        // determine whether the ball goes to the left or the right
        if (Random.value < 0.5f)
            direction.x = -1.0f;
        else
            direction.x = 1.0f;

        // determine the value of the y component of the ball's inital velocity
        if (Random.value < 0.5f)
            direction.y = Random.Range(-1.0f, -0.5f);
        else
            direction.y = Random.Range(0.5f, 1.0f);

        rb2d.AddForce(direction * ballSpeed);
    }

    public void ResetPosition()
    {
        rb2d.position = originalPos;
        rb2d.velocity = Vector2.zero;
        StartForce();
    }
}
