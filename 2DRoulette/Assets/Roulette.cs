using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    float rotSpeed = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed=10;
        }
        transform.Rotate(0,0,this.rotSpeed);
        // transform.Rotate(0,this.rotSpeed,0);
        this.rotSpeed *= 0.98f;
    }
}
