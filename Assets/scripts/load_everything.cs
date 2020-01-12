//Loads audio from local text asset

using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class load_everything : MonoBehaviour
{
    // this Start is for loading from the Asset folder
    void Start()
    {
        int hitID;
        string url; //not a real url for this case - from a folder

        // a random Hit Number

        System.Random rnd = new System.Random();
            hitID = rnd.Next(1, data.numFolders + 1);   //numFolders 1/6/2020
            data.hit_id = hitID;
            Debug.Log("generating random number");
            Debug.Log(hitID);

        for (int i = 0; i < data.numberFiles; i++)
        {
            url = hitID.ToString() + "/" + (i + 1).ToString() + "/" + "fname";   //note leave off the .txt
            {
                TextAsset fname = Resources.Load<TextAsset>(url);
                Debug.Log("Received fname: " + fname.text);
                data.setFileName(i, fname.text);
                parseFname(i, fname.text);
            }

            url =  hitID.ToString() + "/" + (i + 1).ToString() + "/" + data.getFileName(i + 1);
            {
                // remove the .wav for the Load
                string suffix = ".wav";
                Debug.Log("i: " + i);
                if (url.EndsWith(suffix, StringComparison.Ordinal))
                {
                    url = url.Substring(0, url.Length - suffix.Length);
                }
               
                AudioClip audioClip = Resources.Load<AudioClip>(url);
                Debug.Log("Received audio: " + audioClip.name);
                data.setAudio(i, audioClip);
            }
        }
        data.loaded = true;
        Debug.Log("loaded");
    }

 
    private void parseFname(int i, string fname)
    {
        string[] segments = fname.Split(':');

        string numstring = segments[3].Substring(1, segments[3].Length - 1);
        int qnum = Convert.ToInt32(numstring);
        data.setQnum(i, qnum);

        string answer = segments[5].Substring(0, 1);
        bool ans;
        if (answer == "T")
        {
            ans = true;
        }
        else
        {
            ans = false;
        }
        data.setAnswer(i, ans);

    }

}