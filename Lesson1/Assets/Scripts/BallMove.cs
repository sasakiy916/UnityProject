using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.GetComponent<Rigidbody>().useGravity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
