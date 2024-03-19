using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaher : MonoBehaviour
{
    public Image gauge;
    public bool gaugeStart = false;
    float gaugeReductionRate = 0.0025f;

    void Awake()
    {
        gaugeReduce();
        StartCoroutine("CheckGauge");
    }

    void gaugeReduce()
    {
        if(gaugeStart)
        {
            if (score > 10) gaugeReductionRate = 0.0035f;
            if (score > 30) gaugeReductionRate = 0.0045f;
            if (score > 50) gaugeReductionRate = 0.0055f;
            gauge.fillAmount -= gaugeReductionRate;
        }
        Invoke("gaugeReduce", 0.01f);
    }
        
    IEnumerator checkGauge()
    {
        while (gauge.fillAmount!=0)
        {
            yield return new WaitForSeconds(0.4f);
        }   
    }
}
