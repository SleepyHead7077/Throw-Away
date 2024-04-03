using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button Leftbutton;
    public Button Rightbutton;

    // Start is called before the first frame update
    void Start()
    {
        GameObject GameManager = GameObject.Find("GameManager");
        if (GameManager != null)
        {
            Random_System random = GameManager.GetComponentInChildren<Random_System>();

            if (random != null)
            {
                Leftbutton.onClick.AddListener(random.trashBtn);
                Rightbutton.onClick.AddListener(random.recycleBtn);
            }
            else
            {
                Debug.LogError("할당 오류");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}