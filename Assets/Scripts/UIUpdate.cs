using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIUpdate : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public void UpdateScore()
    {
        totalScore++;
        scoreText.text = "SCORE: " + totalScore;
    }
}
