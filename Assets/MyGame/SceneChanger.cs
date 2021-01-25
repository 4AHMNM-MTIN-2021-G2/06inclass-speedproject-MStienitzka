using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
  public void MainScene(){
      SceneManager.LoadScene("Main");
  }

   public void EndScene(){
      SceneManager.LoadScene("End");
  }
    public void ResetScene(){
      SceneManager.LoadScene("Intro");
  }
}
