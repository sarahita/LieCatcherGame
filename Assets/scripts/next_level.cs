//Loads the next level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_level : MonoBehaviour {

    public GameObject TrueBtn;
    public GameObject FalseBtn;
    public GameObject QNum;
    public GameObject QContent;
    public GameObject PlayAudio;

    true_select trueSelectScript;
    false_select falseSelectScript;
    question_number questionNumScript;
    set_question setQuestionScript;
    play_audio playAudioScript;

    string nextSceneName;

	// Use this for initialization
	void Start () {
        //Getting all components that need to be updated when level changes
        trueSelectScript = TrueBtn.GetComponent<true_select>();
        falseSelectScript = FalseBtn.GetComponent<false_select>();
        questionNumScript = QNum.GetComponent<question_number>();
        setQuestionScript = QContent.GetComponent<set_question>();
        playAudioScript = PlayAudio.GetComponent<play_audio>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void NextLevel()
    {
        level_manage.setNextLevel();
        Debug.Log("current level is " + level_manage.getCurrentLevel());
        if (level_manage.getCurrentLevel() > data.numberFiles)
        {
            SceneManager.LoadScene("End Screen", LoadSceneMode.Single);
        }
        else
        {
            Refresh();
        }
    }


    void Refresh()
    {
        trueSelectScript.Refresh();
        falseSelectScript.Refresh();
        questionNumScript.Refresh();
        setQuestionScript.Refresh();
        playAudioScript.Refresh();
        level_manage.setIsClicked(false);
    }
}
