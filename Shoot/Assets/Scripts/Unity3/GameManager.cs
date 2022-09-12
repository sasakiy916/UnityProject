using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUIStyle scoreStyle;
    public GUIStyle msgStyle;
    public float gravity = -9.81f;
    public int Score{
        get;
        set;
    }
    public string Msg{
        get;
        set;
    }

    void Start()
    {
        Physics.gravity = new Vector3(0,gravity,0);
    }
    void Update()
    {
        if(Msg == "GameOver"){
            Time.timeScale = 0f;
            Debug.Log(Msg);
        }
    }

    void OnGUI(){
        GUI.Label(new Rect(5,5,10,10),Score.ToString(),scoreStyle);
        GUI.Label(new Rect(Screen.width/2-150,Screen.height/2-25,300,50),Msg,msgStyle);
    }
}
