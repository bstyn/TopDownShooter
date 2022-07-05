using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int experienceGiven = 10;
    public GameObject scoreCounter;
    public GameObject Player;

    void Start()
    {
        currentHealth = maxHealth;
        scoreCounter = GameObject.FindWithTag("Score");
        Player = GameObject.FindWithTag("Player");
    }

    public void TakeDamage(int damage){

        currentHealth -= damage;

        if(currentHealth <= 0){
            Destroy(gameObject);
            scoreCounter.GetComponent<ScoreCounter>().addScore();
            Player.GetComponent<PlayerExperience>().addExp(experienceGiven);
        }
    }    
}
