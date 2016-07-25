﻿using UnityEngine;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour {

	[SerializeField] private RectTransform healthBarRect;
	[SerializeField] private Text healthText;

	void Start() {
		if (healthBarRect == null) {
			Debug.LogError ("STATUS INDICATOR: No health bar object referenced.");
		}
		if (healthText == null) {
			Debug.LogError ("STATUS INDICATOR: No health text object referenced.");
		}
	}

	public void SetHealth(int _cur, int _max) {
		float _value = (float) _cur / _max;

		healthBarRect.localScale = new Vector3 (_value, healthBarRect.localScale.y, healthBarRect.localScale.z);
		if (healthBarRect.localScale.x <= 0.3) {
			healthBarRect.GetComponent<Image>().color = Color.red;
		} else {
			if (healthBarRect.GetComponent<Image>().color == Color.red) {
				healthBarRect.GetComponent<Image>().color = Color.green;
			}
		}
	
		healthText.text = _cur + "/" + _max + " HP";
	}


}
