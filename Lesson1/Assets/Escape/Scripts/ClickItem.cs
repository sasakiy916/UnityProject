using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickItem : MonoBehaviour,IPointerClickHandler
{
    public Item.Type type;
    public void OnPointerClick(PointerEventData eventData){
        gameObject.SetActive(false);
    }
}
