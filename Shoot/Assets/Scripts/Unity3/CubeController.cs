using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameManager Gm{
        private get;
        set;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet"){
            Gm.Score = Gm.Score + 1;
            Destroy(gameObject,0.1f);
        }
        if(collision.gameObject.tag == "Floor"){
            Gm.Msg = "GameOver";
        }
    }
    // public void SetGameManager(GameManager gm){
    //     this.gm = gm;
    // }
}
