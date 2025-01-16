using _Shooter._Scripts.GameplayRelated;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour, IScoreManager
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    
    //increase the score and update on UI
    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "SCORE: " + score;
    }
}