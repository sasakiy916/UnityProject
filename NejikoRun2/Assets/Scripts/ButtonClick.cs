using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button button;
    float time;
    void Start()
    {
        StartCoroutine(LogText());
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(Input.GetKeyDown("space"))button.onClick.Invoke();
    }
    public void OnClick(){
        Debug.Log("クリック");
    }
    IEnumerator LogText(){
        yield return new WaitForSeconds(1f);
        Debug.Log($"deltaTime:{time} Time:{Time.time}");
        StartCoroutine(LogText());
    }
}
