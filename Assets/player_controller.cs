using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
	public ScoreController scoreController;

	public Animator animator;
	public float speed;
	public float jump;
	private Rigidbody2D rb2d;



	private void Awake()
	{	rb2d = gameObject.GetComponent<Rigidbody2D>();
	}

    internal void KillPlayer()
    {
		Debug.Log(" Player hit the enemy");
	}

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");

        MoverCharacter(horizontal, vertical);
        PlayMovementAnimation(horizontal, vertical);

        Crouch();

    }

	public void PickUpKey()
	{
		Debug.Log(" Player picked up the key");
		scoreController.IncreaseScore(10);
	}

	private void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {            animator.SetTrigger("Crouch");     }
        else
        {      animator.ResetTrigger("Crouch");         }
    }




    private void MoverCharacter(float horizontal, float vertical)
	{   Vector3 position = transform.position;
		position.x += horizontal * speed * Time.deltaTime;
		transform.position = position;

		if (vertical > 0)
		{	rb2d.AddForce(new Vector2(0f, jump), ForceMode2D.Force);	}

	}



	private void PlayMovementAnimation(float horizontal, float vertical)
	{
		animator.SetFloat("speed", Mathf.Abs(horizontal));
		Vector3 scale = transform.localScale;
		transform.localScale = scale;

		if (horizontal < 0)
		{	scale.x = -1f * Mathf.Abs(scale.x);
		}

		else if (horizontal > 0)
		{	scale.x = Mathf.Abs(scale.x);
		}

		if (vertical > 0)
		{	animator.SetBool("Jump", true);
		}

		else
		{	animator.SetBool("Jump", false);
		}
	}
}
