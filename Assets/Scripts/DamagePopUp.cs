using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopUp : MonoBehaviour
{
    private TextMeshPro textMesh;
    private float disappearTimer;
    private Color textColor;

    private const float DISAPPEAR_TIMER_MAX = 0.6f;

    private void Awake(){
        textMesh = transform.GetComponent<TextMeshPro>();
    }
    public static DamagePopUp Create(Vector3 position,int damageAmount){
        Transform damagePopUpTransform = Instantiate(GameAssets.i.pfDamagePopUp, position, Quaternion.identity);
        DamagePopUp damagePopUp = damagePopUpTransform.GetComponent<DamagePopUp>();
        damagePopUp.Setup(damageAmount);
        return damagePopUp;
    }
    public void Setup(int damageAmount){
        textMesh.SetText(damageAmount.ToString());
        textColor = textMesh.color;
        disappearTimer = DISAPPEAR_TIMER_MAX;
    }

    private void Update(){
        float moveYSpeed = 0.05f;
        transform.position += new Vector3(0,moveYSpeed) * Time.fixedDeltaTime;

        if (disappearTimer > DISAPPEAR_TIMER_MAX * 0.5f){
            float increaseScaleAmount = 1f;
            transform.localScale += Vector3.one * increaseScaleAmount * Time.deltaTime;
        } else {
            float decreaseScaleAmount = 1f;
            transform.localScale -= Vector3.one * decreaseScaleAmount * Time.deltaTime;
        }

        disappearTimer -= Time.deltaTime;
        if (disappearTimer <= 0){
            float disappearSpeed = 5f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            textMesh.color = textColor;
            if (textColor.a < 0){
                Destroy(gameObject);
            }
        }
    }
}
