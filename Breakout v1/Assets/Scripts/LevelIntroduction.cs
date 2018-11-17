using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIntroduction : MonoBehaviour {

	public GameObject informationText;
	public GameObject theBall;
	public GameObject thePaddle;
	public float delay = 1.0f;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0))
		{
			Invoke("LevelStart",delay);
		}
	}

	void LevelStart(){
		Destroy(informationText);
		theBall.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
		thePaddle.AddComponent<PaddleMovement>();
		Destroy(gameObject);
	}
}
