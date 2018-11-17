using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneFromMessageScenesToMainTitle : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Escape)){
			Destroy(GameObject.Find("GameMusic"));
			SceneManager.LoadScene(0);
		}
	}
}
