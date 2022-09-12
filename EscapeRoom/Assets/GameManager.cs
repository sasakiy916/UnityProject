using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isClear;
    public Text clearText;
    public GameObject panel;
    Text message;
    public bool isShow;
    void Start()
    {
        if(instance == null){
            instance = this;
        }
        message = panel.GetComponentInChildren<Text>();
    }

    void Update()
    {
        if(isClear){
            clearText.gameObject.SetActive(true);
        }
    }
    public IEnumerator ShowText(string text){
        isShow = true;
        message.text = text;
        panel.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        panel.gameObject.SetActive(false);
        isShow = false;
    }
}
