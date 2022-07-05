using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingCursor : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        Vector3 wPos = Input.mousePosition;
        wPos = Camera.main.ScreenToWorldPoint(wPos);
        Vector3 direction = wPos - player.position;
        direction = direction * 0.1f;
        direction.z = -3;
        
        transform.position = player.position + direction;
    }
}
