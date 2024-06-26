using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseHp : MonoBehaviour
{
    private GameObject scoreObject;
    public Slider slider;
    public bool gaugeStart = true;
    public float gaugeReductionRate = 2.5f;
    public int score = 0;
    public float time = 0f;

    public GameObject gameSceneUI;

    /*
    void Awake()
    {
        gaugeReduce();
        StartCoroutine(CheckGauge());
    }
    */

    private void Start()
    {
        scoreObject = GameObject.Find("GameManager");
    }

    private void Update()
    {
        if (gameSceneUI.activeSelf == false)
        {
            score = scoreObject.GetComponent<GameManager>().score;  // 현 스크립트의 변수 score에 GameManager에서 불러온 score 값 저장
            StartCoroutine(HpReduce());
            StartCoroutine(CheckGauge());
        }
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void CorrectHp()
    {
        slider.value += 3f;
    }

    public void WrongtHp()
    {
        slider.value -= 10f;
    }

    /*
    void gaugeReduce()
    {
        if (gaugeStart)
        {
            if (score > 10 && score < 30) gaugeReductionRate = 0.35f;
            if (score > 30 && score < 50) gaugeReductionRate = 0.45f;
            if (score > 50) gaugeReductionRate = 0.55f;
            slider.value -= gaugeReductionRate;
        }
        Invoke("gaugeReduce", 0.1f);
    }
    */

    IEnumerator HpReduce()
    {
        if (gaugeStart)
        {
            if (score < 1000) gaugeReductionRate = 3f;  // 점수 10미만 초당 X감소
            if (score >= 1000 && score <= 3000) gaugeReductionRate = 4f;  // 초당 X 감소
            if (score >= 3000 && score <= 5000) gaugeReductionRate = 5f;  // 초당 X 감소
            if (score >= 5000) gaugeReductionRate = 8f;  // 초당 X 감소
            slider.value -= gaugeReductionRate * Time.deltaTime;  // 실제 HP 감소 실행 매초 1회
            
            if(slider.value>0)
            {
                time += 1 * Time.deltaTime;  // 시간 얼마나 지났는지 확인하기 위한 코드
            }

            if (slider.value <= 0)
            {
                scoreObject.GetComponent<GameManager>().gameOver = true;  // HP가 0이 되면 GameManager에 GameOver 값 true 전달
                scoreObject.GetComponent<GameManager>().time = time;
            }
        }
        yield return new WaitForSecondsRealtime(1f);
    }

    IEnumerator HpRecover()
    {
        if (gaugeStart)
        {
            if (scoreObject.GetComponent<TrashCheck>().TChecked = true || scoreObject.GetComponent<RecycleCheck>().RChecked == true)
            {
                slider.value += 2.5f * Time.deltaTime;
            }
        }
        yield return new WaitForSecondsRealtime(1f);
    }

    IEnumerator CheckGauge()
    {
        while (slider.value != 0)
        {
            yield return new WaitForSeconds(0.4f);
        }
    }
}
