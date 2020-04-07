var CarControl : GameObject;
var AICar : GameObject;

function Start () {
	CarControl.GetComponent("CarUserControl").enabled = true;
	AICar.GetComponent("CarAIControl").enabled = true;
}

