using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.UI;

public class RandomValuee : MonoBehaviour
{
    public float number;
    public Text value;
    public MyScriptableObject MyData;
    

   public void ValueButton()
   {
        number = UnityEngine.Random.value;
        value.text = number.ToString();
        MyData.randomValue = number;
    }
}