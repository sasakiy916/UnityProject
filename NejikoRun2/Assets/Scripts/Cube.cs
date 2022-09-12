using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube:MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Time.frameCount % 30 == 0){
        Debug.Log("Time.time:"+ Time.time);
        Debug.Log("Time.deltaTime"+ Time.deltaTime);
        Debug.Log("Time.frameCount"+ Time.frameCount);
        Debug.Log("Time.timeScale:"+ Time.timeScale);
      }
        //-10 ~ 10の間を行ったり来たり
        transform.position = new Vector3(
          Mathf.Sin(Time.time * 2f)*10f,
          transform.position.y,
          transform.position.z
        );

        //0~10の間を行ったり来たり
        // transform.position = new Vector3(
        //   Mathf.PingPong(Time.time*10f,10f),
        //   transform.position.y,
        //   transform.position.z
        // );
    }
}
