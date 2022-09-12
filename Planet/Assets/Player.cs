using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce = 10;
    Rigidbody rb;
    bool isJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //前方と重力(惑星の中心)の方向に力を加える
        float z = speed * Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * z + Physics.gravity);
        //横方向(Y軸)に回転
        float rotY = speed * Input.GetAxis("Horizontal");
        transform.Rotate(0, rotY, 0);
        if (Input.GetKeyDown("space")) Jump();
        //重力方向と自分の右方向ベクトルから正面方向のベクトルを取得
        Vector3 forward = Vector3.Cross(Physics.gravity.normalized, transform.right);
        //デバッグ用の赤い光線を正面方向に飛ばす
        Debug.DrawRay(transform.position, forward * 10f, Color.red);
        //forward（正面）を向くように自分を回転させる
        transform.rotation = Quaternion.LookRotation(
            forward,
            Physics.gravity.normalized * -1
        );
    }
    private void OnCollisionEnter(Collision other)
    {
        isJump = false;
    }
    void Jump()
    {
        if (isJump) return;
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        isJump = true;
    }
}
