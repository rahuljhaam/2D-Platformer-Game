using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<player_controller>() != null)
        {
            player_controller player_controller = collision.gameObject.GetComponent<player_controller>();
            player_controller.PickUpKey();
            Destroy(gameObject);
        }
    }
}
