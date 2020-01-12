//Plays the audio for this level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class play_audio : MonoBehaviour {

	AudioSource myAudio;
	GameObject obj1, obj2;

    private bool playFinished;
    private int currentLevelNum;
    private bool set = false;

    // Use this for initialization
    void Start () {
        set = false;
		obj1 = GameObject.Find ("False");
		obj2 = GameObject.Find ("True");
        //Get the nth audio source, where n is the question number
        currentLevelNum = level_manage.getCurrentLevel();

        myAudio = (AudioSource)gameObject.AddComponent <AudioSource> ();
		myAudio.clip = data.getAudio(currentLevelNum);

        playFinished = false;
        obj1.SetActive(false);
        obj2.SetActive(false);
    }
		
	// Update is called once per frame
	void Update () {
        if (!myAudio.isPlaying && playFinished)
        {
            obj1.SetActive(true);
            obj2.SetActive(true);
         
            if(!set){
                data.timeAudioFinish[currentLevelNum - 1] = DateTime.UtcNow.ToString("O");
                Debug.Log("audio finish" + data.timeAudioFinish[currentLevelNum - 1]);
                set = true;
            }

        }
    }

	void OnMouseDown () {
        //Get the nth audio source, where ns is the question number
        if (!level_manage.getIsClicked())
        {
            currentLevelNum = level_manage.getCurrentLevel();
            myAudio.Play();
            data.incrementTimesPlayed(currentLevelNum);
            playFinished = true;
        }
    }

    public void Refresh()
    {
        set = false;
        currentLevelNum = level_manage.getCurrentLevel();

        myAudio = (AudioSource)gameObject.AddComponent<AudioSource>();
        myAudio.clip = data.getAudio(currentLevelNum);

        playFinished = false;
        obj1.SetActive(false);
        obj2.SetActive(false);
    }


}
