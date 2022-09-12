using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int hp = 10;
    void Update()
    {
        if(Input.GetKeyDown("left")){
            transform.Translate(-3,0,0);
        }
        if(Input.GetKeyDown("right")){
            transform.Translate(3,0,0);
        }
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
