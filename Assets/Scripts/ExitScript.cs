using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ExitScript : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Genesis");
    }
    public void Exit()
    {
        Application.Quit();
    }

}
