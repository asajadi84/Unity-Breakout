using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMusicContinueBetweenScenes : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
	}
}
