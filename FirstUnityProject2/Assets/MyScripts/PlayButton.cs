﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnPlayClick()
    {
        SceneManager.LoadScene("SpaceShip");
        Debug.Log("clicked");
    }
}
