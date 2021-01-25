using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowData : MonoBehaviour
{
    public Text time;
    public Text value;
    public Text name;

    public MyScriptableObject MyData;  // Start is called before the first frame update
    void Start()
    {
      time.text = MyData.timestore.ToString();
      value.text = MyData.randomValue.ToString();
      name.text = MyData.myname;
    }

}
