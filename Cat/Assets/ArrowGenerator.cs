using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    // float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateArrow());
    }

    // Update is called once per frame
    void Update()
    {
        // this.delta += Time.deltaTime;
        // if(this.delta > this.span){
        //     this.delta = 0;
        //     GameObject obj = Instantiate(arrowPrefab);
        //     int px = Random.Range(-6,7);
        //     obj.transform.position = new Vector3(px,7,0);
        // }
    }

    IEnumerator GenerateArrow()
    {
        // GameObject obj = Instantiate(arrowPrefab);
        // int px = Random.Range(-6, 7);
        // obj.transform.position = new Vector3(px, 7, 0);
        // yield return new WaitForSeconds(this.span);
        // StartCoroutine(GenerateArrow());
        while(true){
            GameObject obj = Instantiate(arrowPrefab);
            int px = Random.Range(-6,7);
            obj.transform.position = new Vector3(px,7,0);
            yield return new WaitForSeconds(this.span);
        }
    }
}
