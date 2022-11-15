using System;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenuScript : MonoBehaviour
{
	private void Update()
	{
		if (ReInput.controllers.GetLastActiveControllerType() == ControllerType.Joystick & EventSystem.current.currentSelectedGameObject == null)
		{
			if (!this.gc.mouseLocked)
			{
				this.gc.LockMouse();
			}
		}
		else if (ReInput.controllers.GetLastActiveControllerType() != ControllerType.Joystick && this.gc.mouseLocked)
		{
			this.gc.UnlockMouse();
		}
	}

	public GameControllerScript gc;
}