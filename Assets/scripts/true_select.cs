//Controls what happens when the player selects true to a question

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class true_select : MonoBehaviour {

    //giving sound feedback to suggest correct/wrong answer
    public AudioClip correctSound;
    public AudioClip wrongSound;
    public AudioSource audioSource;
    bool playFinished;

    int currentLevelNum;
	bool answer;

	// Use this for initialization
	void Start () {
        //Getting number of current Level
        currentLevelNum = level_manage.getCurrentLevel();
		//Getting answer
		answer = data.getAnswer(currentLevelNum);

        playFinished = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying && playFinished)
        {
            next_level nextLevelScript = GetComponent<next_level>();
            nextLevelScript.NextLevel();
        }
    }

    public void Refresh()
    {
        //Getting number of current Level
        currentLevelNum = level_manage.getCurrentLevel();
        //Getting answer
        answer = data.getAnswer(currentLevelNum);
        
        playFinished = false;
    }

	void OnMouseDown () {
  
        //Update score & sound feedback
        if (!level_manage.getIsClicked())
        {
            Debug.Log("click on true for the first time");
            if (answer)
            {
                int currentScore = score_keeper.getScore;
                currentScore = currentScore + 1;
                score_keeper.getScore = currentScore;
                audioSource.clip = correctSound;
            }
            else
            {
                audioSource.clip = wrongSound;
            }
            audioSource.Play();

            data.timePressAnswer[currentLevelNum - 1] = DateTime.UtcNow.ToString("O");
            //Debug.Log(data.timePressAnswer[currentLevelNum - 1]);
            //Update records of what the player chose
            data.setPlayerAnswer(currentLevelNum, "T");
            playFinished = true;
            level_manage.setIsClicked(true);
        }
        else
        {
            Debug.Log("click on true more than once");
        }

    }
}
