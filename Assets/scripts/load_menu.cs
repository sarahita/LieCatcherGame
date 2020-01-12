//Loads the Menu (to play twice or something)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//If the start button is clicked, move back to menu
	void OnMouseDown(){
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
