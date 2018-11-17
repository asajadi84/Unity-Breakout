using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAddForce : MonoBehaviour {

	public float xVelocity = 0f;
	public float yVelocity = 0f;

	void OnCollisionEnter2D (Collision2D other){
		other.gameObject.GetComponent<Rigidbody2D>().velocity=
			new Vector3(xVelocity,yVelocity,0f);
	}
}
