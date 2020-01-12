//Loads the rules

using UnityEngine;
using UnityEngine.SceneManagement;

public class load_rules : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		SceneManager.LoadScene ("Rules", LoadSceneMode.Single);
	}
}
