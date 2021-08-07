using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerdeath : MonoBehaviour
{
    [SerializeField] private GameObject h1, h2, h3;
    [SerializeField] private GameObject HeartCanvas;
    [SerializeField] private GameObject GameOverCanvas;

    private void Awake()
    {
        HeartCanvas.SetActive(true);
        GameOverCanvas.SetActive(false);
        h1.gameObject.SetActive(true);
        h2.gameObject.SetActive(true);
        h3.gameObject.SetActive(true);
    }
    public void Heart(float health)
    {
        if (health > 3)
        {
            health = 3;
        }
        switch (health)
        {
            case 3:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(true);
                h3.gameObject.SetActive(true);
                break;
            case 2:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(true);
                h3.gameObject.SetActive(false);
                break;
            case 1:
                h1.gameObject.SetActive(true);
                h2.gameObject.SetActive(false);
                h3.gameObject.SetActive(false);
                break;
            case 0:
                h1.gameObject.SetActive(false);
                h2.gameObject.SetActive(false);
                h3.gameObject.SetActive(false);
                Invoke(nameof(stoptime), 1f);
                break;
        }
    }

    public void stoptime()
    {
        HeartCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
