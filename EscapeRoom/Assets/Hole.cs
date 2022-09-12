using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hole : MonoBehaviour,IPointerClickHandler
{
    AudioSource se;
    void Start()
    {
        se = GetComponent<AudioSource>();
    }

    void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData){
        if(!GameManager.instance.isClear){
            GameManager.instance.isClear = true;
            se.Play();
        }
    }
}
