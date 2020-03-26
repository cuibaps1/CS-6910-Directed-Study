using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

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

        if(TimeManager.MinuteCount <= 9)
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
        LapCompleteTrig.SetActive(false);
    }
}
