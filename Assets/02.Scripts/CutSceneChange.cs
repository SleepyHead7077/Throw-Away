using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CutSceneChange : MonoBehaviour
{
    public Sprite[] sprites;
    int clickCnt;
    public string sceneName;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject.Find("ImageChange").GetComponent<Image>().sprite = sprites[0];
        
    }
    public void btnClick()
    {
        clickCnt++;
        if (clickCnt > 3) 
        {
            SceneManager.LoadScene(sceneName);
            clickCnt = 0;
        }
        else { GameObject.Find("ImageChange").GetComponent<Image>().sprite = sprites[clickCnt]; }
    }
}
