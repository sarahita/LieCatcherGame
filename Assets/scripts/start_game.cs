//Starts the first level

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;

public class start_game : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//If the start button is clicked, move onto the level
	void OnMouseDown(){
        SceneManager.LoadScene("Level", LoadSceneMode.Single);
        level_manage.initialLevel();
		data.getStartTime = DateTime.UtcNow.ToString ("O");
	}
}
