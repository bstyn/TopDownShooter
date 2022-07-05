using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage;
    public GameObject hitEffect;

    public void SetBulletDamage(int number){
        bulletDamage = number;
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            DamagePopUp.Create(collision.transform.position,bulletDamage);
            collision.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
        } 
    }

    void Update(){

        transform.Rotate( Vector3.forward.normalized * 360f * Time.deltaTime );
    }
}
