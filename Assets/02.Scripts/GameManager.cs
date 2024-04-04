using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public bool gameOver = false;  // 게임 오버 판정할 변수

    public int score = 0;
    private Random_System manager;  // Random_System 스크립트 정보 받아와서 저장할 변수
    public GameObject btnLeft;
    public GameObject btnRight;

    void Start()
    {
        manager = gameObject.GetComponent<Random_System>();  // Random_System 스크립트 정보 받아와서 변수에 저장
        UpdateScoreText();
    }

    private void Update()
    {
        if (gameOver == true)  // 매 프레임마다 게임오버 상태 체크
        {
            manager.enabled = false;  // 게임 오버 시 Random_System 스크립트 비활성화
            Destroy(btnLeft); // 게임 오버 시 버튼 작동 중지
            Destroy(btnRight);
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