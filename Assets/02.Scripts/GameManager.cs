using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timeText;

    public bool gameOver = false;  // 게임 오버 판정할 변수
    public float time = 0;

    public int score = 0;
    private Random_System manager;  // Random_System 스크립트 정보 받아와서 저장할 변수
    private AudioManager audioManager;  // AudioManager 스크립트 정보 받아와서 저장할 변수

    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject gameSceneUI;
    public GameObject gameOverUI;

    public GameObject happyTurtle;
    public GameObject sadTurtle;

    AudioSource stage;
    AudioSource complete;
    AudioSource correct;
    AudioSource wrong;

    void Start()
    {
        manager = gameObject.GetComponent<Random_System>();  // Random_System 스크립트 정보 받아와서 변수에 저장
        audioManager = gameObject.GetComponent<AudioManager>();  // AudioManager 스크립트 정보 받아와서 변수에 저장
        UpdateScoreText();

        stage = audioManager.stageAS.GetComponent<AudioSource>();
        complete = audioManager.completeAS.GetComponent<AudioSource>();
        correct = audioManager.correctAS.GetComponent<AudioSource>();
        wrong = audioManager.wrongAS.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (gameSceneUI.activeSelf == false)
        {
            btnRight.SetActive(true);
            btnLeft.SetActive(true);
        }
        if (gameSceneUI.activeSelf == true)
        {
            btnRight.SetActive(false);
            btnLeft.SetActive(false);
        }

        if (gameOver == true)  // 매 프레임마다 게임오버 상태 체크
        {
            manager.enabled = false;  // 게임 오버 시 Random_System 스크립트 비활성화
            Destroy(btnLeft); // 게임 오버 시 버튼 작동 중지
            Destroy(btnRight);
            gameOverUI.SetActive(true);
            UpdateTimeText();
            stage.Pause();
            complete.Play();

            if (score >= 8000)
            {
                happyTurtle.SetActive(true);
            }
            else
            {
                sadTurtle.SetActive(true);
            }
        }
    }

    public void IncreaseScore()
    {
        score += 100;
        correct.Play();
        UpdateScoreText();
    }

    public void DecreaseScore()
    {
        score -= 100;
        wrong.Play();
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "" + score;
    }

    void UpdateTimeText()
    {
        timeText.text = "Play Time: " + (int)time;
    }
}