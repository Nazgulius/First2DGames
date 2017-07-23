using System.Collections;
using UnityEngine;

public class AnimKnightJump : MonoBehaviour {
	Animator anim;

	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// при нажатии space вклчается анимация ...
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetBool ("attack", !anim.GetBool ("attack"));

		} 
	}
}
