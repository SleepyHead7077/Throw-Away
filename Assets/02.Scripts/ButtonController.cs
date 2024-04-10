using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Button Leftbutton;
    public Button Rightbutton;

    public GameObject GameSceneUI;
    public GameObject mainCamera;
    public GameObject audioObject;
    private Random_System random;

    public GameObject onSound;
    public GameObject offSound;


    // Start is called before the first frame update
    void Start()
    {
        // GameSceneUI = GameObject.Find("GameSceneUI");

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

    private void Update()
    {
        
    }

    /*
    public void TrashBtn()
    {
        random.trashBtn();
    }

    public void RecycleBtn()
    {
        random.recycleBtn();
    }
    */

    public void MenuBtn()
    {
        if (GameSceneUI.activeSelf == false)
        {
            Debug.Log("False");
            GameSceneUI.SetActive(true);
        }
        else if (GameSceneUI.activeSelf == true)
        {
            Debug.Log("True");
            GameSceneUI.SetActive(false);
        }
    }

    public void GameUIHome()
    {
        SceneManager.LoadScene("01.StartScene");
    }

    public void GameUIResume()
    {
        GameSceneUI.SetActive(false);
    }

    public void GameUIRestart()
    {
        SceneManager.LoadScene("02.GameScene");
    }

    public void GameUIQuit()
    {
        Application.Quit();
    }

    public void GameUISoundOff()
    {
        audioObject.SetActive(false);
        onSound.SetActive(false);
        offSound.SetActive(true);
        //audioListener.enabled = false;
    }

    public void GameUISoundOn()
    {
        audioObject.SetActive(true);
        onSound.SetActive(true);
        offSound.SetActive(false);
        //audioListener.enabled = true;
    }
}