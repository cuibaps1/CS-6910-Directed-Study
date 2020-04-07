using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public RectTransform mPanelMapInitialize;

    public Text mTxtGameOver;

    public Button BackButton;
    public Button AIModeButton;
    public Button NextButton;

	
    public void PlayGame()
    {
        mPanelMapInitialize.gameObject.SetActive(false);
    }
}
