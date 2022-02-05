using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RollABallManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreLabel;
    public TMP_Text WinText;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        WinText.text = "";
        
    }
    

    public void UpdateScore(int coinValue)
    {
        this.score = score+coinValue;
        this.scoreLabel.text = this.score.ToString();

        if(score >=36)
        {
            WinText.text = "You Win!!";
        }
    }
}
