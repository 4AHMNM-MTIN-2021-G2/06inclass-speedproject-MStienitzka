using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameInput : MonoBehaviour
{
    [SerializeField] InputField namefield;
    string name;
    public MyScriptableObject MyData;
    
    public void MyName()
    {
        name = namefield.text;
        MyData.myname = name;
    }
}
