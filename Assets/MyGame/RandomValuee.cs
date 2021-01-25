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
        number = UnityEngine.Random.Range(1.0f, 10.0f);
        value.text = number.ToString();
        MyData.randomValue = number;
    }
}