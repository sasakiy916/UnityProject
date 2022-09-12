using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubu : MonoBehaviour
{
    Vector3 ang=Vector3.zero;
    Coroutine cor;
    // Start is called before the first frame update
    void Start()
    {
        cor = StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(ang);
        if(Input.GetKeyDown("space"))StopCoroutine(cor);
    }
    IEnumerator Move(){
        Debug.Log("1");
        yield return new WaitForSeconds(2f);
        ang.x = 2f;
        Debug.Log("2");
        yield return new WaitForSeconds(5f);
        ang.x = 0;
        ang.y = 2f;
        Debug.Log("3");
        yield return new WaitForSeconds(2f);
        ang = new Vector3(1f,1f,1f);
        Debug.Log("4");
    }
}
