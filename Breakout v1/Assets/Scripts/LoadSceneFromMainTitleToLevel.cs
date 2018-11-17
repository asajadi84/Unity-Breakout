using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneFromMainTitleToLevel : MonoBehaviour {

	void Awake () {
		Screen.sleepTimeout=SleepTimeout.NeverSleep;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonUp(0)){
			SceneManager.LoadScene(1);
		}

		if(Input.GetKeyUp(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
