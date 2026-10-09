using UnityEngine;
using UnityEngine.InputSystem;

public class setingsjugador3 : MonoBehaviour
{
    public float speed;
    public float direction;
    public Rigidbody2D Rb;

    public float jumpForce;
    public bool canJump;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rb.linearVelocity = new Vector2(direction * speed, Rb.linearVelocityY);
        canJump = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }


    public void Move(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>().x;

    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && canJump)
        {
            Rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        


}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("mud"))
        {
            speed /= 2;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("mud"))
        {
            speed *= 2;
        }
    }
}
