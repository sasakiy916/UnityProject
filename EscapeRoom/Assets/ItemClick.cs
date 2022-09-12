using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemClick : MonoBehaviour,IPointerClickHandler
{
    public GameObject[] items;
    [HideInInspector] public int count = 0;
    bool isOpen;
    AudioSource se;
    void Awake()
    {
        se = GetComponent<AudioSource>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        items[count++].gameObject.SetActive(false);
        if(count == items.Length)count = 0;
        items[count].gameObject.SetActive(true);
        if(count == 2){
            se.Play();
        }
    }
}
