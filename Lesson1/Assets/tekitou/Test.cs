using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        Instantiate(ball);
    }
}
