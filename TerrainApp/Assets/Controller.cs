using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveForce;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.right * Input.GetAxis("Horizontal") * moveForce + transform.forward * Input.GetAxis("Vertical") * moveForce;
        float angle = Input.GetAxis("Horizontal") * 5;
        rb.AddForce(move);
        transform.Rotate(0,angle,0);
    }
}
