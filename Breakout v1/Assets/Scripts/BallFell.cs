using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallFell : MonoBehaviour {

	public float gameOverDelay = 0.5f;

	void OnTriggerEnter2D (Collider2D other){
		Destroy(other.gameObject);
		Invoke("GameOver", gameOverDelay);
	}

	void GameOver(){
		SceneManager.LoadScene(2);
	}
}
