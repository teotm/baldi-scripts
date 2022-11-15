using System;
using Rewired;
using UnityEngine;

public class ClickableTest : MonoBehaviour
{
	private void Start()
	{
		this.playerInput = ReInput.players.GetPlayer(0);
	}

	private void Update()
	{
		if (this.playerInput.GetButtonDown("Interact"))
		{
			Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f));
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && raycastHit.transform.name == "MathNotebook")
			{
				base.gameObject.SetActive(false);
			}
		}
	}

	private Player playerInput;
}
