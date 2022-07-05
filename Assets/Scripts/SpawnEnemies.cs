using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{   
    public Transform Player;
    public GameObject Enemy;
    public GameObject[] enemy;
    public int amount;
    public float height;
    public float width;
    public Camera cam;

    
    void Start(){
        cam = Camera.main;
        height = cam.orthographicSize + 1;
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update ()
    {
        enemy = GameObject.FindGameObjectsWithTag ("Enemy");
        amount = enemy.Length;
        if (amount < 10) 
        {
            InvokeRepeating ("spawnEnemy", 1f, 2f);
        }
    }
    void spawnEnemy()
    {
        GameObject enemyClone = Instantiate (Enemy,new Vector3((cam.transform.position.x + Random.Range(-6,6)),(cam.transform.position.y) + height*(Random.Range(0,2)*2-1),2), Quaternion.identity);
        enemyClone.GetComponent<EnemyFollowPlayer>().SetPlayer(Player);
        CancelInvoke ();
    }
}
