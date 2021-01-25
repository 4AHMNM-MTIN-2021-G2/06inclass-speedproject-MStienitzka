using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowName : MonoBehaviour
{
    public Text name;
    public Text value;

    public MyScriptableObject MyData;  // Start is called before the first frame update
    void Start()
    {
      name.text = MyData.myname;
    }
    public void ButtonPressed() {
      value.text = MyData.randomValue.ToString();
    }

}
