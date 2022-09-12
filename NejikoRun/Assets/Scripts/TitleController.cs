using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Text highScoreText;
    void Start()
    {
        //ハイスコアを表示
        highScoreText.text = "High Score:" + PlayerPrefs.GetInt("HiScore") + "m";
    }
    public void OnStartButtonClick(){
        SceneManager.LoadScene("Main");
    }
}
