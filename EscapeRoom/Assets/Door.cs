using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour,IPointerClickHandler
{
    bool isOpen;
    public Cube cube;
    public ItemClick items;
    AudioSource[] se;
    void Awake()
    {
        se = GetComponents<AudioSource>();
    }
    public void OnPointerClick(PointerEventData eventData){
        if(cube.isMoved){
            if(items.count == 2){
                //扉が開く時
                if(!isOpen) {
                    transform.Rotate(0,-120,0);
                    isOpen = true;
                }
                else{
                    transform.Rotate(0,120,0);
                    isOpen = false;
                }
                se[0].Play();
            }else if(!isOpen){
                //鍵かかってる時
                if(!GameManager.instance.isShow){
                    StartCoroutine(GameManager.instance.ShowText("鍵がかかってるようだ・・・"));
                    se[1].Play();
                }
            }
        }else{
            //キューブが邪魔な時
            if(!GameManager.instance.isShow){
                StartCoroutine(GameManager.instance.ShowText("扉の前にモノがあって開かない・・・"));
                se[1].Play();
            }
        }
    }
}
