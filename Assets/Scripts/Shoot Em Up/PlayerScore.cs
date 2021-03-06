﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerScore : MonoBehaviour {

    //public GameObject playerScoreUI;
    public GameObject playerTimeUI;
    public GameObject playerScoreUI;
    public GameObject playerKillsUI;
    public static bool hasWon;

    public int delay = 2;

    private float timeLeft = 0;


    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Kills", 0);
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft += Time.deltaTime;
        playerTimeUI.gameObject.GetComponent<Text>().text = ("Time:" + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = "Score: " + (PlayerPrefs.GetInt("Score") + "");
        playerKillsUI.gameObject.GetComponent<Text>().text = "Kills: " + (PlayerPrefs.GetInt("Kills") + "");
    }
}
