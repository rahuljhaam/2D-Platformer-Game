using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour

{
    public LevelCompleteScripts LevelComplete;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<player_controller>())
        {
           // Debug.Log("Level Finished");
         LevelManager.Instance.MarkCurrentLevelComplete();
            LevelComplete.LevelCompleted();
           // LevelManager.Instance.SetLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
        }
    }
}
   
    
   