using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float jump;

    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");

        MoverCharacter(horizontal, vertical);
        PlayMovementAnimation(horizontal, vertical);


        if (Input.GetKey(KeyCode.LeftControl))
        {


            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            animator.SetTrigger("Crouch");
        }
        else
        {
            animator.ResetTrigger("Crouch");
        }








    }
    //Player actual Movement
    private void MoverCharacter(float horizontal, float vertical)
    {   //move character horizontal
        Vector3 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime;
        transform.position = position;

        //move character vertical
        if (vertical > 0)
        {
            rb2d.AddForce(new Vector2(0f, jump), ForceMode2D.Force);
        }

    }




    private void PlayMovementAnimation(float horizontal, float vertical)
    {
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        Vector3 scale = transform.localScale;



        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);


        }

        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;


        //float vertical = Input.GetAxisRaw("Jump");

        if (vertical > 0)
        {
            animator.SetBool("Jump", true);
            //  Input.GetKeyDown(KeyCode.Space);


        }

        else
        {
            animator.SetBool("Jump", false);
        }
    }
}
