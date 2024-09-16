using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<player_controller>() != null)
        {
            player_controller player_Controller = collision.gameObject.GetComponent<player_controller>();
            player_Controller.KillPlayer();
        }
    }
}
