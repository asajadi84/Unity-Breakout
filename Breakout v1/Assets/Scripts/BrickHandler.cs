using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickHandler : MonoBehaviour {

	public int Hit = 2;
	public Sprite brokenBrick;
	public float congratSceneLoadDelay = 0.4f;
	public AudioClip brickHit;
	public AudioClip brickBreak;

	void OnCollisionEnter2D (Collision2D other){
		Hit--;
		if(Hit==1){
			AudioSource.PlayClipAtPoint(brickHit, transform.position);
			transform.GetComponent<SpriteRenderer>().sprite=brokenBrick;
		}
		if(Hit==0){
			NumberOfBricksLeftController.bricksLeft--;
			AudioSource.PlayClipAtPoint(brickBreak, transform.position);
			Destroy(gameObject);
			Debug.Log("number of bricks left: " + NumberOfBricksLeftController.bricksLeft);

			if(NumberOfBricksLeftController.bricksLeft==0){
				SceneManager.LoadScene(3);
			}
		}
	}
}
