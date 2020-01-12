using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    private static bool flag = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (data.loaded == true){
            if(flag == false)
            {
                flag = true;
                Destroy(gameObject);
            }
        }
    }
}
