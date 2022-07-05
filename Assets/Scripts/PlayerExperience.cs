using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExperience : MonoBehaviour
{
    public int Level = 1;
    public float ExpNeeded = 100;
    public float CurrExp = 0;
    public Image fillBar;
    public TMP_Text levelIcon;

    void Update()
    {
        if (CurrExp >= ExpNeeded){
            ExpNeeded = 100 + Level * (100+50);
            Level += 1;
            setLevel(Level);
            CurrExp = 0;
            fillBar.fillAmount = 0;
        }
    }

    public void addExp(int amount){
        CurrExp += amount;
        fillBar.fillAmount = CurrExp/ExpNeeded;
    }

    private void setLevel(int number){
        levelIcon.text = number.ToString();
    }
}
