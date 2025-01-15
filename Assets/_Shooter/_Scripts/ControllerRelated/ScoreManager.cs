using _Shooter._Scripts.GameplayRelated;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void OnEnable()
    {
        GameEvents.OnTargetHit += UpdateScore;
    }

    private void OnDisable()
    {
        GameEvents.OnTargetHit -= UpdateScore;
    }

    //increase the score and update on UI
    private void UpdateScore()
    {
        score += 10;
        scoreText.text = "SCORE: " + score;
    }
}