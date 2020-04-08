﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadTime : MonoBehaviour {

    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

	// Use this for initialization
	void Start () {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");

        MinDisplay.GetComponent<Text>().text = "" + MinCount + ":";
        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;
    }
	
}