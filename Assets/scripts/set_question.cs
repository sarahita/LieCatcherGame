//Sets the text field for the question text of the current level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class set_question : MonoBehaviour {

	string question;
    int currentLevelNum;

	// Use this for initialization
	void Start () {
        //Getting number of current Level
        currentLevelNum = level_manage.getCurrentLevel();
		//Getting question content
		int qnum = data.getQnum(currentLevelNum);
		question = questions.getQuestion(qnum);

		//Set question
		Text myText = GetComponent<Text>();
		myText.text = question; 
	}

    public void Refresh()
    {
        currentLevelNum = level_manage.getCurrentLevel();
        //Getting question content
        int qnum = data.getQnum(currentLevelNum);
        question = questions.getQuestion(qnum);

        //Set question
        Text myText = GetComponent<Text>();
        myText.text = question;
    }

    // Update is called once per frame
    void Update () {

	}

}
