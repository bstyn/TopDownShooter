using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

    public int score = 0;

    public void addScore(){
        int scoreLength = 7;
        score += 1;

        string scoreString = score.ToString();
 
        int numZeros = scoreLength - scoreString.Length;
        
        string newScore = "";
        for(int i = 0; i < numZeros; i++){
            newScore += "0";
        }
        TMP_Text scoreUi = gameObject.GetComponent<TMP_Text>();
        scoreUi.text = newScore + scoreString;
    }
}
