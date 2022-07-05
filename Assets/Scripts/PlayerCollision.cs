using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public float health = 100f;
    public float damageToTake = 40;
    public float currentHealth;
    public TMP_Text healthText;

    void Start(){
        currentHealth = health;
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy")
        {
            takeDamage(damageToTake);
        } 
        if ( currentHealth <= 0){
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    public void takeDamage(float damage){
        currentHealth -= damage;
        healthText.text = currentHealth.ToString();
    }

}
