//Controls what happens when the player selects false to a question

using UnityEngine;
using System;

public class false_select : MonoBehaviour {

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
    void Update () {
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

        if (!level_manage.getIsClicked())
        {
            Debug.Log("click on false for the first time");

            //Update score&sound feedback
            if (!answer)
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
            Debug.Log(data.timePressAnswer[currentLevelNum - 1]);
            //Update records of what the player chose
            data.setPlayerAnswer(currentLevelNum, "F");
            playFinished = true;
            level_manage.setIsClicked(true);
        }
        else
        {
            Debug.Log("click on false more than once");
        }
    }

}
