using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public bool gameOver = false;

    public int score = 0;
    private Random_System manager;

    void Start()
    {
        manager = gameObject.GetComponent<Random_System>();
        UpdateScoreText();
    }

    private void Update()
    {
        if (gameOver == true)
        {
            manager.enabled = false;
        }
    }

    public void IncreaseScore()
    {
        score++;
        UpdateScoreText();
    }

    public void DecreaseScore()
    {
        score--;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "" + score;
    }
}