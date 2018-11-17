using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewportCalculator : MonoBehaviour {

	public static float xEdgeInUnityUnits;
	public BoxCollider2D upObstacle;
	public BoxCollider2D leftObstacle;
	public BoxCollider2D rightObstacle;
	public BoxCollider2D downObstacle;
	
	void Awake () {
		NumberOfBricksLeftController.bricksLeft=NumberOfBricksLeftController.totalBricks;

		float unityUnitsInPixels = Screen.height / (2 * Camera.main.orthographicSize);
		xEdgeInUnityUnits = (Screen.width / unityUnitsInPixels) / 2;
		Debug.Log(xEdgeInUnityUnits);

		upObstacle.gameObject.transform.position = new Vector3(
			upObstacle.gameObject.transform.position.x,
			Camera.main.orthographicSize + (upObstacle.size.y/2),
			upObstacle.gameObject.transform.position.z
		);
		upObstacle.size = new Vector2(xEdgeInUnityUnits*2, upObstacle.size.y);

		leftObstacle.gameObject.transform.position = new Vector3(
			-xEdgeInUnityUnits-(leftObstacle.size.x/2),
			leftObstacle.gameObject.transform.position.y,
			leftObstacle.gameObject.transform.position.z
		);
		leftObstacle.size = new Vector2(leftObstacle.size.x,Camera.main.orthographicSize*2);

			rightObstacle.gameObject.transform.position = new Vector3(
			xEdgeInUnityUnits+(rightObstacle.size.x/2),
			rightObstacle.gameObject.transform.position.y,
			rightObstacle.gameObject.transform.position.z
		);
		rightObstacle.size = new Vector2(rightObstacle.size.x,Camera.main.orthographicSize*2);

		downObstacle.gameObject.transform.position = new Vector3(
			downObstacle.gameObject.transform.position.x,
			-(Camera.main.orthographicSize) - (downObstacle.size.y/2),
			downObstacle.gameObject.transform.position.z
		);
		downObstacle.size = new Vector2(xEdgeInUnityUnits*2, downObstacle.size.y);
	}
}
