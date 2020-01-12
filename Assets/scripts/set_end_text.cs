//Sets the text field for the score

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_end_text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Text myText = GetComponent<Text>();
		myText.text = "Thanks for playing! You scored: " + score_keeper.getScore + "/"
                    + data.numberFiles + "\n \n"
					+ "Your ID is: " + data.getHit_id + "\n \n"
					+ "Keep your ID for the End Of Game Survey\n"
			+ "Remember to complete\n"
			+ "the post-game survey, then\n"
			+ "submit the HIT\n"
			+ "on Mechanical Turk!";
	}

	// Update is called once per frame
	void Update () {

	}
}
