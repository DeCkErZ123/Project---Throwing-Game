using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIUpdate : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public void UpdateScore() // is called from the Scorer script
    {
        totalScore++; // increases the score counter by 1
        scoreText.text = "SCORE: " + totalScore; // updates the UI text to display the updated score amount.
    }
}
