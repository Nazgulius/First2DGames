using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charecter : MonoBehaviour {


	//private int lives = 5;

	private float speed = 10.0f;

	private float jumpForce = 25.0f;

	private bool isGrounded = true;

	new private Rigidbody2D rigidbody;
	private Animator animator;
	private SpriteRenderer sprite;

	private CharState State {
		get { return (CharState)animator.GetInteger("State"); }
		set { animator.SetInteger("State", (int) value); }
	}

	private void Awake(){
		rigidbody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
		sprite = GetComponentInChildren<SpriteRenderer> ();
	}

	private void FixedUplate(){
		CheckGround ();  // проверка неличия земли не вызывается, не срабатывает
	}

	void Update () {
		State = CharState.Idle;

		if (Input.GetButton ("Horizontal"))
			Walk ();
		if (isGrounded && Input.GetKeyDown (KeyCode.Space)) Jump ();
	}

	private void Walk (){
		Vector3 direction = transform.right * Input.GetAxis ("Horizontal");
		transform.position = Vector3.MoveTowards (transform.position, transform.position + direction, speed * Time.deltaTime);
		sprite.flipX = direction.x < 0.0f;

		State = CharState.Walk;
	}

	private void Jump(){

		State = CharState.Jump;
		rigidbody.AddForce (transform.up * jumpForce, ForceMode2D.Impulse);
	}

	// проверка наличия земли
	private void CheckGround(){  
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, 5.0f);
		isGrounded = true /*colliders.Length > 1  - должен передавать true если больше 1*/;
	}
}


public enum CharState {
	Idle,
	Walk,
	Jump
}