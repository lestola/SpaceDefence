using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceshipscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.Box(new Rect(5, 5, 0, 0), "This is a box");
    }
}
