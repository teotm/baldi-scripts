using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTriggerScript : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (this.gc.notebooks >= 7 & other.tag == "Player")
		{
			if (this.gc.failedNotebooks >= 7)
			{
				SceneManager.LoadScene("Secret");
			}
			else
			{
				SceneManager.LoadScene("Results");
			}
		}
	}

	public GameControllerScript gc;
}