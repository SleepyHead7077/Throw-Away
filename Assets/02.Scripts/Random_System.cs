using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_System : MonoBehaviour
{
    //쓰레기 및 재활용 쓰레기 변수
    public GameObject trash1;
    public GameObject trash2;
    public GameObject recycle1;
    public GameObject recycle2;

    //오브젝트 위치 변수
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;

    private GameObject random;
    //private GameObject random1;
    //private GameObject random2;
    //private GameObject random3;
    //private GameObject random4;

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
        if (Input.GetKeyDown(KeyCode.Space))  //스페이스 누르면 첫 번째 오브젝트 삭제 후 새 오브젝트 생성 및 이동
            makeRandom_item();
    }

    void startRandom_item()  //시작 시 랜덤한 오브젝트 설정 후 배치
    {
        int rvalue1 = Random.Range(0, 3);
        int rvalue2 = Random.Range(0, 3);
        int rvalue3 = Random.Range(0, 3);
        int rvalue4 = Random.Range(0, 3);

        switch(rvalue1)
        {
            case 0:
                rStart1 = trash1;
                break;
            case 1:
                rStart1 = trash2;
                break;
            case 2:
                rStart1 = recycle1;
                break;
            case 3:
                rStart1 = recycle2;
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
                rStart2 = recycle1;
                break;
            case 3:
                rStart2 = recycle2;
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
                rStart3 = recycle1;
                break;
            case 3:
                rStart3 = recycle2;
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
                rStart4 = recycle1;
                break;
            case 3:
                rStart4 = recycle2;
                break;
        }

        Instantiate(rStart1, pos1);  //생성
        Instantiate(rStart2, pos2);
        Instantiate(rStart3, pos3);
        Instantiate(rStart4, pos4);
    }

    void makeRandom_item()  //스페이스 누르면 첫 번째 오브젝트 삭제 후 새 오브젝트 생성 및 이동
    {
        int makeRandom_value = Random.Range(0, 3);

        switch(makeRandom_value)  //random 변수에 새로운 오브젝트 할당
        {
            case 0:
                random = trash1;
                break;
            case 1:
                random = trash2;
                break;
            case 2:
                random = recycle1;
                break;
            case 3:
                random = recycle2;
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