using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageTerrain : MonoBehaviour
{
    public Renderer renderTerrain;
    public Transform Player;
    float tempScroll;
    float speed = 0.2f;

    private void Update() {
        renderTerrain.material.mainTextureOffset = new Vector2(-Player.position.y*speed,Player.position.x*speed);
    }
}
