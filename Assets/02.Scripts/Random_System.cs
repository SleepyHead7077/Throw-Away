using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random_System : MonoBehaviour
{
    //쓰레기 및 재활용 쓰레기 변수
    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;
    public GameObject trash4;
    public GameObject trash5;
    public GameObject trash6;
    public GameObject trash7;
    public GameObject trash8;
    public GameObject trash9;
    public GameObject trash10;
    public GameObject recycle1;
    public GameObject recycle2;
    public GameObject recycle3;
    public GameObject recycle4;
    public GameObject recycle5;
    public GameObject recycle6;
    public GameObject recycle7;
    public GameObject recycle8;
    public GameObject recycle9;
    public GameObject recycle10;

    //오브젝트 위치 변수
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;

    public Transform tPos;
    public Transform rPos;

    private GameObject random;

    private GameObject rStart1;
    private GameObject rStart2;
    private GameObject rStart3;
    private GameObject rStart4;

    // Start is called before the first frame update
    void Start()
    {
        startRandom_item();  //시작 시 랜덤한 오브젝트 설정 후 배치
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))  //
            trashBtn();

        if (Input.GetKeyDown(KeyCode.RightArrow))  //
            recycleBtn();
    }

    void startRandom_item()  //시작 시 랜덤한 오브젝트 설정 후 배치
    {
        int rvalue1 = Random.Range(0, 20);
        int rvalue2 = Random.Range(0, 20);
        int rvalue3 = Random.Range(0, 20);
        int rvalue4 = Random.Range(0, 20);

        switch(rvalue1)
        {
            case 0:
                rStart1 = trash1;
                break;
            case 1:
                rStart1 = recycle1;
                break;
            case 2:
                rStart1 = trash2;
                break;
            case 3:
                rStart1 = recycle2;
                break;
            case 4:
                rStart1 = trash3;
                break;
            case 5:
                rStart1 = recycle3;
                break;
            case 6:
                rStart1 = trash4;
                break;
            case 7:
                rStart1 = recycle4;
                break;
            case 8:
                rStart1 = trash5;
                break;
            case 9:
                rStart1 = recycle5;
                break;
            case 10:
                rStart1 = trash6;
                break;
            case 11:
                rStart1 = recycle6;
                break;
            case 12:
                rStart1 = trash7;
                break;
            case 13:
                rStart1 = recycle7;
                break;
            case 14:
                rStart1 = trash8;
                break;
            case 15:
                rStart1 = recycle8;
                break;
            case 16:
                rStart1 = trash9;
                break;
            case 17:
                rStart1 = recycle9;
                break;
            case 18:
                rStart1 = trash10;
                break;
            case 19:
                rStart1 = recycle10;
                break;
        }

        switch (rvalue2)
        {
            case 0:
                rStart2 = trash1;
                break;
            case 1:
                rStart2 = trash2;
                break;
            case 2:
                rStart2 = trash3;
                break;
            case 3:
                rStart2 = trash4;
                break;
            case 4:
                rStart2 = trash5;
                break;
            case 5:
                rStart2 = trash6;
                break;
            case 6:
                rStart2 = trash7;
                break;
            case 7:
                rStart2 = trash8;
                break;
            case 8:
                rStart2 = trash9;
                break;
            case 9:
                rStart2 = trash10;
                break;
            case 10:
                rStart2 = recycle1;
                break;
            case 11:
                rStart2 = recycle2;
                break;
            case 12:
                rStart2 = recycle3;
                break;
            case 13:
                rStart2 = recycle4;
                break;
            case 14:
                rStart2 = recycle5;
                break;
            case 15:
                rStart2 = recycle6;
                break;
            case 16:
                rStart2 = recycle7;
                break;
            case 17:
                rStart2 = recycle8;
                break;
            case 18:
                rStart2 = recycle9;
                break;
            case 19:
                rStart2 = recycle10;
                break;
        }

        switch (rvalue3)
        {
            case 0:
                rStart3 = trash1;
                break;
            case 1:
                rStart3 = trash2;
                break;
            case 2:
                rStart3 = trash3;
                break;
            case 3:
                rStart3 = trash4;
                break;
            case 4:
                rStart3 = trash5;
                break;
            case 5:
                rStart3 = trash6;
                break;
            case 6:
                rStart3 = trash7;
                break;
            case 7:
                rStart3 = trash8;
                break;
            case 8:
                rStart3 = trash9;
                break;
            case 9:
                rStart3 = trash10;
                break;
            case 10:
                rStart3 = recycle1;
                break;
            case 11:
                rStart3 = recycle2;
                break;
            case 12:
                rStart3 = recycle3;
                break;
            case 13:
                rStart3 = recycle4;
                break;
            case 14:
                rStart3 = recycle5;
                break;
            case 15:
                rStart3 = recycle6;
                break;
            case 16:
                rStart3 = recycle7;
                break;
            case 17:
                rStart3 = recycle8;
                break;
            case 18:
                rStart3 = recycle9;
                break;
            case 19:
                rStart3 = recycle10;
                break;
        }

        switch (rvalue4)
        {
            case 0:
                rStart4 = trash1;
                break;
            case 1:
                rStart4 = trash2;
                break;
            case 2:
                rStart4 = trash3;
                break;
            case 3:
                rStart4 = trash4;
                break;
            case 4:
                rStart4 = trash5;
                break;
            case 5:
                rStart4 = trash6;
                break;
            case 6:
                rStart4 = trash7;
                break;
            case 7:
                rStart4 = trash8;
                break;
            case 8:
                rStart4 = trash9;
                break;
            case 9:
                rStart4 = trash10;
                break;
            case 10:
                rStart4 = recycle1;
                break;
            case 11:
                rStart4 = recycle2;
                break;
            case 12:
                rStart4 = recycle3;
                break;
            case 13:
                rStart4 = recycle4;
                break;
            case 14:
                rStart4 = recycle5;
                break;
            case 15:
                rStart4 = recycle6;
                break;
            case 16:
                rStart4 = recycle7;
                break;
            case 17:
                rStart4 = recycle8;
                break;
            case 18:
                rStart4 = recycle9;
                break;
            case 19:
                rStart4 = recycle10;
                break;
        }

        Instantiate(rStart1, pos1);  //생성
        Instantiate(rStart2, pos2);
        Instantiate(rStart3, pos3);
        Instantiate(rStart4, pos4);
    }

    public void trashBtn()
    {
        StartCoroutine(MoveTrash());
    }

    IEnumerator MoveTrash()
    {
        pos1.transform.GetChild(0).position = Vector3.MoveTowards(transform.position, tPos.position, 3f);

        yield return new WaitForSecondsRealtime(0.2f);

        makeRandom_item();
    }

    public void recycleBtn()
    {
        StartCoroutine(MoveRecycle());
    }

    IEnumerator MoveRecycle()
    {
        pos1.transform.GetChild(0).position = Vector3.MoveTowards(transform.position, rPos.position, 3f);

        yield return new WaitForSecondsRealtime(0.2f);

        makeRandom_item();
    }

    void makeRandom_item()  //스페이스 누르면 첫 번째 오브젝트 삭제 후 새 오브젝트 생성 및 이동
    {
        int makeRandom_value = Random.Range(0, 20);

        switch(makeRandom_value)  //random 변수에 새로운 오브젝트 할당
        {
            case 0:
                random = trash1;
                break;
            case 1:
                random = trash2;
                break;
            case 2:
                random = trash3;
                break;
            case 3:
                random = trash4;
                break;
            case 4:
                random = trash5;
                break;
            case 5:
                random = trash6;
                break;
            case 6:
                random = trash7;
                break;
            case 7:
                random = trash8;
                break;
            case 8:
                random = trash9;
                break;
            case 9:
                random = trash10;
                break;
            case 10:
                random = recycle1;
                break;
            case 11:
                random = recycle2;
                break;
            case 12:
                random = recycle3;
                break;
            case 13:
                random = recycle4;
                break;
            case 14:
                random = recycle5;
                break;
            case 15:
                random = recycle6;
                break;
            case 16:
                random = recycle7;
                break;
            case 17:
                random = recycle8;
                break;
            case 18:
                random = recycle9;
                break;
            case 19:
                random = recycle10;
                break;
        }

        rStart1 = rStart2;
        rStart2 = rStart3;
        rStart3 = rStart4;
        rStart4 = random;

        Destroy(pos1.transform.GetChild(0).gameObject);  //삭제
        Destroy(pos2.transform.GetChild(0).gameObject);
        Destroy(pos3.transform.GetChild(0).gameObject);
        Destroy(pos4.transform.GetChild(0).gameObject);

        Instantiate(rStart1, pos1);  //생성
        Instantiate(rStart2, pos2);
        Instantiate(rStart3, pos3);
        Instantiate(random, pos4);
    }
}