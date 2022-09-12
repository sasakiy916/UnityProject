using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float jumpForce = 680f;
    public float walkForce = 30f;
    public float maxWalkSpeed = 2f;
    bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGround && Input.GetButtonDown("Jump")){
            rb.AddForce(transform.up * jumpForce);
            animator.SetBool("Jump",true);
        }
        float speedx = Mathf.Abs(rb.velocity.x);
        float dir = Input.GetAxisRaw("Horizontal");
        //歩く速さが最大になるまで力加える
        if(speedx < maxWalkSpeed){
            rb.AddForce(transform.right * dir * walkForce);
        }
        //スプライトを向きに合わせて左右反転させる
        if(dir != 0){
            transform.localScale = new Vector3(dir,1f,1f);
        }
        if(speedx != 0){
            animator.SetBool("walk",true);
            animator.speed = speedx / 2.0f;
        }else{
            animator.SetBool("walk",false);
            animator.speed = 1;
        }
        if(Input.GetKeyDown("escape") || transform.position.y < -10)SceneManager.LoadScene("Main");
        AnimatorStateInfo animators = animator.GetCurrentAnimatorStateInfo(0);
        Debug.Log(animators.IsName("Jump"));
        Debug.Log(Savepoi.isClear);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");
    }
    private void OnCollisionStay2D(Collision2D other) {
        isGround = true;
    }
    private void OnCollisionExit2D(Collision2D other) {
        isGround = false;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        animator.SetBool("Jump",false);
    }
}
