using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Assignment 9 //
public class DespawnOnHeight : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
    // Update is called once per frame
	void Update () {
		if (transform.position.y <= -4) {
			SceneManager.LoadScene("GameOver");
			MazeNumber.number = 0;

			var whisper = GameObject.Find("WhisperSource");
			GameObject.Destroy(whisper);
		}
	}

}