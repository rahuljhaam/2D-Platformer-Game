using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}