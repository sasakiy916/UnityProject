using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.transform.position);
        Debug.Log(this.transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
