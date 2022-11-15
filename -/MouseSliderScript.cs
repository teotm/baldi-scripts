using System;
using UnityEngine;
using UnityEngine.UI;

public class MouseSliderScript : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetFloat("MouseSensitivity") < 100f)
		{
			PlayerPrefs.SetFloat("MouseSensitivity", 200f);
		}
		this.slider.value = PlayerPrefs.GetFloat("MouseSensitivity");
	}

	private void Update()
	{
		PlayerPrefs.SetFloat("MouseSensitivity", this.slider.value);
	}

	public Slider slider;
}