//Sets the text field for the question number

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class question_number : MonoBehaviour {

    int currentLevelNum;

	// Use this for initialization
	void Start () {
        //Getting number of current level
        currentLevelNum = level_manage.getCurrentLevel();
		//Set text
		Text myText = GetComponent<Text>();
		myText.text = "Question " + currentLevelNum; 
	}

    public void Refresh()
    {
        currentLevelNum = level_manage.getCurrentLevel();
        //Set text
        Text myText = GetComponent<Text>();
        myText.text = "Question " + currentLevelNum;
    }

    // Update is called once per frame
    void Update () {

	}
}
