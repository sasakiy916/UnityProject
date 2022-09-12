using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroy : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    public GameObject effectPrefabs;
    public Vector3 effectRotation;
    public bool IsReward;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Candy"){
            //指定数だけCandyのストックを増やす
            candyManager.AddCandy(reward);
            //オブジェクトを削除
            Destroy(other.gameObject);
        }
        Vector3 pos = Vector3.zero;
        if(IsReward)pos.y += 10;


        if(effectPrefabs != null){
            //Candyのポジションにエフェクトを生成
            Instantiate(
                effectPrefabs,
                other.transform.position + pos,
                Quaternion.Euler(effectRotation)
            );
        }
    }
}
