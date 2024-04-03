using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCheck : MonoBehaviour
{
    public GameManager gameManager;

    public Transform pos;

    public GameObject Correct;
    public GameObject Wrong;

    public bool TChecked = false; //제대로 분류했을때를 확인하여 체력을 회복시키기 위하여 만들어졌습니다

    private IEnumerator OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "TRASH")
        {
            StartCoroutine(Green());
            gameManager.IncreaseScore();
            TChecked = true;
            yield return new WaitForSecondsRealtime(0.01f);
            TChecked = false;
        }

        if (coll.gameObject.tag == "RECYCLE")
        {
            StartCoroutine(Red());
            gameManager.DecreaseScore();
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
