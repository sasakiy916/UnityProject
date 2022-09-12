using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDirector : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;
    // public GameObject holeReed;

    void Update()
    {
        // if(holeReed.transform.position.y < 0){
        //     holeReed.transform.position = new Vector3(
        //         Mathf.Clamp(holeReed.transform.position.x,-5.5f,5.5f),
        //         1,
        //         Mathf.Clamp(holeReed.transform.position.z,-8.0f,8.0f)
        //         );
        // }
    }
    void OnGUI()
    {
        //全てのボールが入ったらラベルを表示
        if(holeRed.IsHolding() && holeBlue.IsHolding() && holeGreen.IsHolding()){
            GUI.Label(new Rect(50,50,200,60),"Game Clear");
        }
    }
}
