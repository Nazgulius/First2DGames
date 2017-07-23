using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimKnightWalk : MonoBehaviour {
	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();	
	}
	

	void Update () {
		float v = Input.GetAxis ("Horizontal");
		anim.SetFloat ("walk", v);
	}
}
