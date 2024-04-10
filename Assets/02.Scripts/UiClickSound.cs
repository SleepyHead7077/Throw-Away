using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiClickSound : MonoBehaviour
{
    private AudioSource uiClick;
    public GameObject audioObject;

    // Start is called before the first frame update
    void Start()
    {
        uiClick = gameObject.GetComponent<AudioSource>();
    }

    public void ClickedUi()
    {
        if (audioObject.activeSelf == true)
        {
            uiClick.Play();
        }
    }
}
