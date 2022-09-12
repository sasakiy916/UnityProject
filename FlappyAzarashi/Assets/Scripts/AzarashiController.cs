﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzarashiController : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    float angle;
    bool isDead;

    public float maxHeight;
    public float flapVelecity;
    public float relativeVelocityX;
    public GameObject sprite;

    public bool IsDead(){
        return isDead;
    }

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = sprite.GetComponent<Animator>();
    }

    void Update()
    {
        //最高高度に達していない場合に限りタップの入力を受け付ける
        if(Input.GetButtonDown("Fire1") && transform.position.y < maxHeight){
            Flap();
        }

        //角度を繁栄
        ApplyAngle();

        //angleが水平以上だったら、アニメーターのflapフラグをtrueにする
        animator.SetBool("flap",angle >= 0.0f && !isDead);

    }

    public void Flap(){
        //死んだらはばたけない
        if(isDead)return;

        //重力が効いていないときは操作しない
        if(rb2d.isKinematic)return;

        //Velocityyを直接書き換えて上方に加速
        rb2d.velocity = new Vector2(0.0f,flapVelecity);
    }

    void ApplyAngle(){
        //現在の速度、相対速度から進んでいる角度を求める
        float targetAngle;

        //死亡したら常にひっくり返る
        if(isDead){
            targetAngle = 180.0f;
        }else{
            targetAngle = Mathf.Atan2(rb2d.velocity.y,relativeVelocityX) * Mathf.Rad2Deg;
        }

        //回転アニメをスムージング
        angle = Mathf.Lerp(angle,targetAngle,Time.deltaTime * 10.0f);

        //Rotationの繁栄
        sprite.transform.localRotation = Quaternion.Euler(0.0f,0.0f,angle);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(isDead)return;

        //クラッシュエフェクト
        Camera.main.SendMessage("Clash");
        //何かにぶつかったら死亡フラグをたてる
        isDead = true;
    }

    public void SetSteerActive(bool active){
        //Rigidbodyのオン、オフを切り替える
        rb2d.isKinematic = !active;
    }
}
