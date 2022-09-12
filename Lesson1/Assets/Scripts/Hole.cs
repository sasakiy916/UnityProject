using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public string targetTag;
    bool isHolding;

    //ボールが入っているかを返す
    public bool IsHolding(){
        return isHolding;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == targetTag){
            isHolding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == targetTag){
            isHolding = false;
        }
    }
    void OnTriggerStay(Collider other){
        //コライダに触れているオブジェクトのRigidbodyコンポーネントを取得
        Rigidbody r = other.GetComponent<Rigidbody>();

        //ボールがどの方向にあるかを計算
        Vector3 direction = other.transform.position - this.transform.position;
        direction.Normalize();

        //タグに応じてボールに力を加える
        if(other.tag == targetTag){
            if(targetTag=="BallGreen")Debug.Log("当たった");
            //中心地点でボールを止めるため速度を減少させる
            r.velocity *= 0.9f;
            r.AddForce(direction * -20.0f,ForceMode.Acceleration);
        }else{
            r.AddForce(direction * 80.0f,ForceMode.Acceleration);
        }
    }
}
