using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public static int point;
    Text pointText;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        pointText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = point.ToString();
    }
}
