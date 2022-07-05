using UnityEngine;

public class FirepointFollowPlayer : MonoBehaviour
{
    public Transform player;
   
    void Update () {

        // Moving firepoint alongside player in a certain radius

        // Vector3 wPos = Input.mousePosition;
        // wPos.z = player.position.z-Camera.main.transform.position.z;
        // wPos = Camera.main.ScreenToWorldPoint(wPos);
        // Vector3 direction = wPos - player.position;

        // float radius = 0.35f;
        // direction = direction.normalized*radius;

        // transform.position = player.position+direction;

        // Following player closely

        transform.position = player.transform.position;
    }
}
