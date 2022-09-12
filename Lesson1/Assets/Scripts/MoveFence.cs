using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFence : MonoBehaviour
{
    public float move;
    public float speed;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos  = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = move * Mathf.Sin(Time.time * speed);
        transform.position = pos + new Vector3(x,0,0);
    }
}
