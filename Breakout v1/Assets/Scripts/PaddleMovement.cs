using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {
	
	private Vector3 mousePosition;
	public float paddleMoveLimit = 2.0f;
	public float paddleSpeed = 4.0f;

	// Update is called once per frame
	void Update () {
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3 (
			Mathf.Lerp(
				transform.position.x,
				Mathf.Clamp(
					mousePosition.x,
					-(ViewportCalculator.xEdgeInUnityUnits)+paddleMoveLimit,
					ViewportCalculator.xEdgeInUnityUnits-paddleMoveLimit
				),
				paddleSpeed*Time.deltaTime
			),
			transform.position.y,
			transform.position.z);
	}
}
