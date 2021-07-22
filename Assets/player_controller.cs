using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Animator animator;
    public float speed;

    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}

    // Update is called once per frame
    private void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        float translation = Input.GetAxis("Vertical") * speed;
        animator.SetFloat("speed", Mathf.Abs(speed));
        Vector3 scale = transform.localScale;

        if (Input.GetKey(KeyCode.LeftControl))
        {


            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            animator.SetTrigger("Crouch");
        }
        else
        {
            animator.ResetTrigger("Crouch");
        }
        if (speed < 0)
        {
            scale.x = -1f * scale.x;


        }

        else if (speed > 0)
        {
            scale.x = Mathf.Abs(scale.x);
            animator.SetTrigger("Jump");

        }

        transform.localScale = scale;

    }
}
