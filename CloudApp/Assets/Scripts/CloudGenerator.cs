using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
        public GameObject prefab;


    public Transform clouds;
    Vector3[] positions ={
        new Vector3(1.0f,16.6f,0),
        new Vector3(1.4f,13.2f,0),
        new Vector3(1.2f,9.0f,0),
        new Vector3(2.2f,6.4f,0),
        new Vector3(1.7f,2.5f,0),
        new Vector3(2.1f,-2.1f,0),
        new Vector3(0f,-5.1f,0),
        new Vector3(1.8f,-5.1f,0),
        new Vector3(-1.1f,15.5f,0),
        new Vector3(-2.0f,13.0f,0),
        new Vector3(-1.0f,11.0f,0),
        new Vector3(-2.1f,7.7f,0),
        new Vector3(-0.1f,4.2f,0),
        new Vector3(-1.8f,1.8f,0),
        new Vector3(-0.2f,-0.7f,0),
        new Vector3(-2.0f,-2.8f,0),
        new Vector3(-1.8f,-5.1f,0),

    };
    Vector3[] scales={
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(0.9f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1.2f,1f,1f),
        new Vector3(1.2f,1f,1f),
        new Vector3(0.6f,1f,1f),
        new Vector3(0.7f,1f,1f),
        new Vector3(0.8f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1f,1f,1f),
        new Vector3(1.2f,1f,1f),

    };
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<17;i++){
            GameObject cloud = Instantiate(prefab);
            cloud.transform.position = positions[i];
            cloud.transform.localScale = scales[i];
            cloud.transform.parent = clouds;
        }
    }

}
