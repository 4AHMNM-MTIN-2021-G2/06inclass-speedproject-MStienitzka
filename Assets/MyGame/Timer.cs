using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float mytime;
    public Text showtime;
    public MyScriptableObject MyData;
    // Update is called once per frame
    
    void Update()
    {
        mytime = Time.time;
        showtime.text = mytime.ToString();
        MyData.timestore = mytime;
    }
}
