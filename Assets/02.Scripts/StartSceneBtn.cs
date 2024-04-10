using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneBtn : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;

    public GameObject audioObject;
    public GameObject onSound;
    public GameObject offSound;

    private AudioSource uiClick;

    private void Start()
    {
        uiClick = gameObject.GetComponent<AudioSource>();
    }

    public void StartCutScene()
    {
        scene1.SetActive(true);
    }

    public void CutScene2()
    {
        scene1.SetActive(false);
        scene2.SetActive(true);
    }

    public void CutScene3()
    {
        scene2.SetActive(false);
        scene3.SetActive(true);
    }

    public void CutScene4()
    {
        scene3.SetActive(false);
        scene4.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("02.GameScene");
    }

    public void UIQuit()
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

    public void UiClickSound()
    {
        uiClick.Play();
    }
}
