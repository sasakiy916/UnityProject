﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    public Text score;
    public GameObject startButton;
    private Coroutine game;
    private bool isPlay;
    public GameObject formPanel;
    public GameObject RankingPanel;

    void Update()
    {
        if(isPlay && Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit,100.0f)){
                if(hit.collider.name=="Cube"){
                    StopCoroutine(game);
                    isPlay = false;
                    formPanel.SetActive(true);
                }
            }
        }
    }
    IEnumerator RandomNum(){
        while(true){
            transform.Rotate(0,10.0f,0);
            yield return new WaitForSeconds(0.3f);
            score.text = Random.Range(0,10000).ToString();
        }
    }
    public void StartClick(){
        game = StartCoroutine(RandomNum());
        startButton.SetActive(false);
        isPlay = true;
        //古いランキングデータは削除
        Transform cells = RankingPanel.transform.FindChild("Cells");
        for(int i=0;i<cells.childCount;i++){
            GameObject.Destroy(cells.GetChild(i).gameObject);
        }
        //スクロールを先頭に戻す
        Vector3 vec = cells.localPosition;
        vec.y = 0f;
        cells.localPosition = vec;
        //非表示
        RankingPanel.SetActive(false);
    }
}
