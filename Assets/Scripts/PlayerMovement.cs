using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public Camera cam;
    public Rigidbody2D rb;
    bool facingRight = true;

    Vector2 movement;
    Vector2 mousePos;

    void Update(){

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;
    }

    void FixedUpdate(){

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        var delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; 

        if (delta.x >= 0 && !facingRight) { // mouse is on right side of player
            transform.rotation = Quaternion.Euler(0,0,0);
            facingRight = true;
        } else if (delta.x < 0 && facingRight) { // mouse is on left side
            transform.rotation = Quaternion.Euler(0,180,0);
            facingRight = false;
        }

    }
}
