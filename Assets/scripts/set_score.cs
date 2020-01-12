//Sets the text field for the score

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class set_score : MonoBehaviour {

    Text myText;

    // Use this for initialization
    void Start()
    {
        //GameObject obj = GameObject.Find ("Score");
        //obj.SetActive (false);
        myText = GetComponent<Text>();
        myText.text = "Score : " + score_keeper.getScore;
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Score : " + score_keeper.getScore;
        //Debug.Log("Score = " + score_keeper.getScore);
    }
}
