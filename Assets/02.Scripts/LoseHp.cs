using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManaher : MonoBehaviour
{
    private GameObject scoreObject;
    public Slider slider;
    public bool gaugeStart = true;
    public float gaugeReductionRate = 2.5f;
    public int score = 0;
    public float time = 0f;

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
        score = scoreObject.GetComponent<GameManager>().score;
        StartCoroutine(HpReduce());
        StartCoroutine(CheckGauge());
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
            if (score < 10) gaugeReductionRate = 2.5f;
            if (score >= 10 && score <= 30) gaugeReductionRate = 3.5f;
            if (score >= 30 && score <= 50) gaugeReductionRate = 4.5f;
            if (score >= 50) gaugeReductionRate = 5.5f;
            slider.value -= gaugeReductionRate * Time.deltaTime;
            time += 1 * Time.deltaTime;

            if (slider.value <= 0)
            {
                scoreObject.GetComponent<GameManager>().gameOver = true;
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