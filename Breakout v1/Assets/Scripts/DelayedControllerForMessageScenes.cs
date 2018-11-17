using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedControllerForMessageScenes : MonoBehaviour {

	public float controllerDelay = 2.0f;
	
	void Awake () {
		Destroy(GameObject.Find("GameMusic"));
		Invoke("AddComponentToMessageScene", controllerDelay);
	}
	
	void AddComponentToMessageScene(){
		gameObject.AddComponent<LoadSceneFromMessageScenesToMainTitle>();
	}
}
