using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
	public ScoreController scoreController;
	public GameOVerController gameOverController;
	public Animator animator;
	public float speed;
	private float horizontal;
	private float vertical;
	public float  jump;
	private bool isGrounded;
	private string GROUND_TAG = "Ground";

	private bool crouching;
	private Rigidbody2D rb2d;
	[SerializeField] private Playerdeath playerdeath;
	private float jumpForce = 8f;
	public float health;


	private void Awake()
	{
		rb2d = gameObject.GetComponent<Rigidbody2D>();
	}

	internal void KillPlayer()
	{
		//Health.heath -= 1;
		gameOverController.PlayerDied();
		Debug.Log(" Player hit the enemy");
		this.enabled = false;
	}



	void Update()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
	//	float vertical = Input.GetAxisRaw("Jump");

		MoverCharacter(horizontal, vertical);
		PlayMovementAnimation(horizontal, vertical);

		Crouch();
	}

	private void FixedUpdate()
    {
		PlayerJump();
	}

	public void PickUpKey()
	{
		Debug.Log(" Player picked up the key");
		scoreController.IncreaseScore(10);
	}

	private void Crouch()
	{
		if (Input.GetKey(KeyCode.LeftControl))
		{ animator.SetTrigger("Crouch"); }
		else
		{ animator.ResetTrigger("Crouch"); }
	}




	private void MoverCharacter(float horizontal, float vertical)
	{
		Vector3 position = transform.position;
		position.x += horizontal * speed * Time.deltaTime;
		transform.position = position;

		rb2d.AddForce(new Vector2(0f, (vertical * jump)), ForceMode2D.Force);


	}



	private void PlayMovementAnimation(float horizontal, float vertical)
	{
		animator.SetFloat("speed", Mathf.Abs(horizontal));
		Vector3 scale = transform.localScale;
		transform.localScale = scale;

		if (horizontal < 0)
		{
			scale.x = -1f * Mathf.Abs(scale.x);
		}

		else if (horizontal > 0)
		{
			scale.x = Mathf.Abs(scale.x);
		}
		transform.localScale = scale;

	}

	void PlayerJump()
    {
		if(Input.GetButtonDown("Jump") && isGrounded)
		{
			isGrounded = false;
			rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

			Debug.Log("Jump pressed"); }
    }

	private void OnCollisionEnter2D(Collision2D collision)
    {
		if(collision.gameObject.CompareTag("Ground"))
        {
			isGrounded = true;

		}

	}
}
