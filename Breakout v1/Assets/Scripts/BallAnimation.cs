using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour {

	public float headDelay = 0.3f;
	private Animator thisAnimator;

	void Awake () {
		thisAnimator = transform.GetComponent<Animator>();
	}
	
	void OnCollisionEnter2D (Collision2D other){
		thisAnimator.SetBool("Hurt", true);
		Invoke("Heal", headDelay);
	}

	void Heal(){
		thisAnimator.SetBool("Hurt", false);
	}
}
