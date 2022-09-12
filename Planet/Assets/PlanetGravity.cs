using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public Transform player;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (transform.position - player.position).normalized;
        Physics.gravity = dir * gravity;
    }
}
