using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string nextScene;
    
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.BackQuote))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
