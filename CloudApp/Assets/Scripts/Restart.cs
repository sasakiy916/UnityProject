using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))SceneManager.LoadScene("Main");
        Debug.Log(Savepoi.isClear);
    }
}
