//Writes report info to local file

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Globalization;

using UnityEditor;         

public class write_report : MonoBehaviour {

	[DllImport("__Internal")]
	private static extern void SyncFiles();
    public TextAsset output;       

	// Use this for initialization
	void Start () {

		//Structure of csv: hitID:startTime:fname1:playerAnswer1:timesPlayed1: 2...13 :testQuestionNum:Score:endTime\n

		string entry = "";
		entry = entry + data.getHit_id
		+ "," + data.getStartTime;

		for (int i = 0; i < data.numberFiles; i++) {//1/6/2020  (was 13)
			entry = entry + "," + data.getFileName (i + 1).Replace(System.Environment.NewLine, "")
			+ "," + data.getPlayerAnswer (i + 1)
            + "," + data.timeAudioFinish[i]
            + "," + data.timePressAnswer[i];
		}

		entry = entry + "," + data.getTest_position
		+ "," + score_keeper.getScore
			+ "," + DateTime.UtcNow.ToString("O")
			+ "\n" ;

		print (entry);

        Save(entry, data.getStartTime);

	}

    void Save (string entry, string dateTime)
    {
        
        AssetDatabase.SaveAssets();

        File.WriteAllText(Application.dataPath + "/Reports/" + dateTime + ".txt", entry);
        AssetDatabase.Refresh();
    }
		


}
