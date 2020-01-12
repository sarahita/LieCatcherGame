//Starts the first level

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Globalization;

public class loading : MonoBehaviour {

	public GameObject obj;
    private static bool flag = false;

    // Use this for initialization
    void Start () {
		obj = GameObject.Find("Begin");
		obj.SetActive (false);
    }
	
	// Update is called once per frame
	void Update () {
        if (data.loaded == true)
        {
            if (flag == false)
            {
                flag = true;
                obj.SetActive(true);
            }
        }
    }

}
