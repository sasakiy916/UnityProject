using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text distance;
    public Transform car;
    public Transform flag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float   length = flag.position.x - car.position.x;
        distance.text = $"ゴールまで{length:F2}m";
    }
}
