using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube : MonoBehaviour,IPointerClickHandler
{
    public bool isMoved;
    Vector3 pos;
    AudioSource se;
    // Start is called before the first frame update
    void Start()
    {
        se = GetComponent<AudioSource>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //デバッグ用
        if(!isMoved){
            transform.position = pos;
        }
    }
    public void OnPointerClick(PointerEventData eventData){
        if(!isMoved){
            transform.Translate(-0.9f,0,0);
            isMoved = true;
            se.Play();
        }
    }
}
