using System.Net.Http.Headers;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text showtime;
    public MyScriptableObject MyData;
    // Update is called once per frame
    
    void Update() {
        MyData.timestore = Time.timeSinceLevelLoad;
        showtime.text = MyData.timestore.ToString();
    }
}
