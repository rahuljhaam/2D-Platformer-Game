﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(speed));
        Vector3 scale = transform.localScale;


        if (speed < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);


        }

        else if (speed > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;






    }
}
