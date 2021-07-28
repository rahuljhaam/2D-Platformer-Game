﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void RestartBtn(string SceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }
}