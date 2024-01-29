using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
  public void PlayGame()
  {
    //SceneManager.LoadScene("igra");
    SceneManager.LoadScene("level1");
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
