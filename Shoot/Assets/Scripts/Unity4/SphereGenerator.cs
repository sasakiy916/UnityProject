using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    void Start()
    {
        for(int y=0;y<10;y++){
            for(int x=0;x<10;x++){
                for(int z=0;z<10;z++){
                    GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    obj.transform.position = new Vector3((float)x,(float)y,(float)z);
                    obj.GetComponent<MeshRenderer>().material.color = Color.red;
                }
            }
        }
    }
}
