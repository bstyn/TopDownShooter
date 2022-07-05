using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Rigidbody2D player;
    public float height;
   
    void Update () {
        transform.position = player.transform.position + new Vector3(0,0,height);
    }
}
