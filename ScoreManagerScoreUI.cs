using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int _score = 0;

    private void Awake(){
        if(instance == null){
            instance = this;
        }
    }
    public void AddScore(int points){
        _score += points;
        scoreText.text = "Score: " + _score.ToString();
    }
}
