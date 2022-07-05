using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform Player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 1.25f;
    
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        Vector3 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        
    }
    private void FixedUpdate() {
        MoveEnemy(movement);
    }
    public void SetPlayer(Transform player){
        Player = player;
    }
    public void MoveEnemy(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
