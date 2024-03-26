using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManaher : MonoBehaviour
{
    public int score = 0;
    public Slider slider;
    public bool gaugeStart = false;
    float gaugeReductionRate = 0.025f;

    void Awake()
    {
        gaugeReduce();
        StartCoroutine("CheckGauge");
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

    void gaugeReduce()
    {
        if (gaugeStart)
        {
            if (score > 10) gaugeReductionRate = 0.035f * Time.deltaTime;
            if (score > 30) gaugeReductionRate = 0.045f * Time.deltaTime;
            if (score > 50) gaugeReductionRate = 0.055f * Time.deltaTime;
            slider.value -= gaugeReductionRate * Time.deltaTime;
        }
        Invoke("gaugeReduce", 0.01f);
    }

    IEnumerator checkGauge()
    {
        while (slider.value != 0)
        {
            yield return new WaitForSeconds(0.4f);
        }
    }
}