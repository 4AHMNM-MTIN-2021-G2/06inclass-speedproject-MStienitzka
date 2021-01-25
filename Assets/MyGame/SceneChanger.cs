using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
  public MyScriptableObject Data;
  public Button Name;
  public Color Color;
  public void MainScene()
  {
      if (Data.myname == "")
      {
          Debug.Log("TypeYourName");
          Name.image.color = Color;

      }
      else
      {
        SceneManager.LoadScene("Main"); 
      }
          
  }

   public void EndScene()
  
  {
    if (Data.randomValue > 1f)
    {
    SceneManager.LoadScene("End");   
    }
  }
    public void ResetScene()
  {
      SceneManager.LoadScene("Intro");
      Data.myname = "";
      Data.randomValue = 0;
      Data.timestore = (0);
  }
}
