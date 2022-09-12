using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Transform target;
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetMouseButton(0)){
            //等速で目的地に移動する
            // transform.position = Vector3.MoveTowards(
            //     transform.position,
            //     target.position,
            //     5f * Time.deltaTime
            // );

            //減速しながら目的地に移動(線形補完)
            transform.position = Vector3.Lerp(
                transform.position,
                target.position,
                1f * Time.deltaTime
            );

            //減速しながら目的地に移動(球面線形補完)
            // transform.position = Vector3.Slerp(
            //     transform.position,
            //     target.position,
            //     1f * Time.deltaTime
            // );
        }
    }
}
