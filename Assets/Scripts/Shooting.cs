using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletDamage;
    public float attackRate = 2f;
    public float nextAttackTime = 0f;

    public float bulletForce = 5f;

    private void Update() {
        
        if(Time.time >= nextAttackTime){
            if(Input.GetMouseButton(0)){
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
        
    }

    void Shoot(){
        GameObject player = GameObject.FindWithTag("Player");
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Bullet>().SetBulletDamage(bulletDamage);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        bullet.transform.Rotate(0,0,90,Space.Self);
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Physics2D.IgnoreCollision(bullet.GetComponent<BoxCollider2D>(), player.GetComponent<BoxCollider2D>());
        Destroy(bullet,2f);
    }
}
