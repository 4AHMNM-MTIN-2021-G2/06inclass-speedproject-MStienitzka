using UnityEngine;
using UnityEngine.UI;

public class Feedback : MonoBehaviour
{
    public MyScriptableObject data;
    public Text result;
    void Start()
    {
        if (data.timestore <= 3)
        {
            result.text = "Your time was good";
        }
        else if (data.timestore <= 6)
        {
           result.text = "Your time was decent"; 
        }
        else
        {
           result.text = "You timing is unacceptable"; 
        }
    }
    }

