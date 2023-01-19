using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public KeyCode keyUp;
    public KeyCode keyDown;
    public float paddleSpeed = 10.0f;

    private Rigidbody2D rb2d;
    private Vector2 direction;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(keyDown) && Input.GetKey(keyUp))
            direction = Vector2.zero;
        else if (Input.GetKey(keyDown))
            direction = Vector2.down;
        else if (Input.GetKey(keyUp))
            direction = Vector2.up;
        else
            direction = Vector2.zero;
    }

    void FixedUpdate()
    {
        rb2d.velocity = direction * paddleSpeed;
    }
}
