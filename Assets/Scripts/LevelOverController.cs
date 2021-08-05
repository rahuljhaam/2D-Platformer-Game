using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelOverController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<player_controller>() != null)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Level Finished by the player");
        }
    }
}
