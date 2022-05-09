using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Genesis");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
