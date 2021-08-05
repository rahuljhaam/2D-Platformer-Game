using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOVerController : MonoBehaviour
{
    public Button buttonRestart;
    public Button ExitButton;


    private void Awake()
    {
        buttonRestart.onClick.AddListener(Restart);
        ExitButton.onClick.AddListener(Exit);

    }
    public void PlayerDied()
    {
        gameObject.SetActive(true);
    }

    public void Exit()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }


}
