using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float rotSpeed=0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed=10f;
            rb.velocity = new Vector3(
                Random.Range(-2f,2f),
                20f,
                Random.Range(-2f,2f)
            );
        }
        transform.Rotate(0,rotSpeed,0);
        this.rotSpeed *= 0.99f;
    }
}