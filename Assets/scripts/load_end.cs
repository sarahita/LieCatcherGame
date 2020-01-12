//Loads the end screen
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_end : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		SceneManager.LoadScene ("End Screen", LoadSceneMode.Single);
	}
}
