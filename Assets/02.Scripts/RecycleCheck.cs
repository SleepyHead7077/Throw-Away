using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleCheck : MonoBehaviour
{
    public GameManager gameManager;
    private LoseHp loseHp;
    public GameObject hpBar;

    public Transform pos;

    public GameObject Correct;
    public GameObject Wrong;

    // public bool RChecked = false; //제대로 분류했을때를 확인하여 체력을 회복시키기 위하여 만들어졌습니다

    private void Start()
    {
        loseHp = hpBar.GetComponent<LoseHp>(); // hpBar 에서 LoseHp 스크립트 정보 받아와서 변수에 저장
    }

    private IEnumerator OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "TRASH")
        {
            StartCoroutine(Red());
            gameManager.DecreaseScore();
            loseHp.WrongtHp(); // 재활용에 쓰레기 HP 감소
        }

        if (coll.gameObject.tag == "RECYCLE")
        {
            StartCoroutine(Green());
            gameManager.IncreaseScore();
            // RChecked = true;
            yield return new WaitForSecondsRealtime(0.01f);
            // RChecked = false;
            loseHp.CorrectHp(); // 재활용에 재활용 HP 회복
        }
    }

    IEnumerator Green()
    {
        Instantiate(Correct, pos);

        yield return new WaitForSecondsRealtime(0.1f);

        Destroy(pos.transform.GetChild(0).gameObject);
    }

    IEnumerator Red()
    {
        Instantiate(Wrong, pos);

        yield return new WaitForSecondsRealtime(0.1f);

        Destroy(pos.transform.GetChild(0).gameObject);
    }
}
