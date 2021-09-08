using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void Change(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
    //public void LoadGameScene()
    //{
    //    SceneManager.LoadScene("SampleScene");
    //}

    public void Exit()
    {
        Application.Quit();
    }

}