using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class GameManager : MonoBehaviour
{
    
  
    public void LoadDeathScreen()
    {
        //var temp = GetComponent<ScoreManager>();
        //temp.OnGameOver();
        SceneManager.LoadScene(2);
    }
    public  void CaptureScreenshot(string filename, int superSize)
    {
        ScreenCapture.CaptureScreenshot("Death.png");
    }

}
