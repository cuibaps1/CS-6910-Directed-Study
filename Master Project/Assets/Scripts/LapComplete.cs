using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;
    public GameObject CarControls;

    public GameObject CountDown;
    public RectTransform mPanelGameOver;
    public RectTransform mPanelMapInitialize;
    public RectTransform mPanelTimer;

    public Text mTxtGameOver;

    public Button BackButton;
    public Button AIModeButton;
    public Button NextButton;

    

    public void ChangeMenuScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void PlayGame()
    {
        mPanelMapInitialize.gameObject.SetActive(false);
        mPanelTimer.gameObject.SetActive(true);
        CountDown.SetActive(true);
    }

    void OnTriggerEnter()
    {
        if (TimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + TimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + TimeManager.SecondCount + ".";
        }

        if (TimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + TimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + TimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + TimeManager.MilliCount;
        TimeManager.MinuteCount = 0;
        TimeManager.SecondCount = 0;
        TimeManager.MilliCount = 0;

        HalfLapTrig.SetActive(true);
        mPanelGameOver.gameObject.SetActive(true);
        CarControls.SetActive(false);


        LapCompleteTrig.SetActive(false);
    }
}
