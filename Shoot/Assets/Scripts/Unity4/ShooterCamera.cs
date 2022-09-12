using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterCamera : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // RaycastHit hit;

            //最初にRayに当たったオブジェクトを削除
            // if(Physics.Raycast(ray,out hit,100f)){
            //     Destroy(hit.collider.gameObject);
            // }

            //Rayの当たった全てのオブジェクトを削除(直線状)
            foreach(RaycastHit hit in Physics.RaycastAll(ray)){
                Destroy(hit.collider.gameObject);
            }

            //Rayの当たった全てのオブジェクトを削除(当たった箇所を中心に半径〇内のモノ)
            foreach(RaycastHit hit in Physics.SphereCastAll(ray,3f)){
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
