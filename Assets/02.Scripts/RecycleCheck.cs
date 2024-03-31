using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleCheck : MonoBehaviour
{
    public GameManager gameManager;

    public Transform pos;

    public GameObject Correct;
    public GameObject Wrong;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "TRASH")
        {
            StartCoroutine(Red());
            gameManager.DecreaseScore();
        }

        if (coll.gameObject.tag == "RECYCLE")
        {
            StartCoroutine(Green());
            gameManager.IncreaseScore();
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
