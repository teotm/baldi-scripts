using System;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
	private void Start()
	{
		this.player = ReInput.players.GetPlayer(0);
	}

	public void OnEnable()
	{
		this.uc.firstButton = this.firstButton;
		this.uc.dummyButtonPC = this.dummyButtonPC;
		this.uc.dummyButtonElse = this.dummyButtonElse;
		this.uc.SwitchMenu();
	}

	private void Update()
	{
		if (this.player.GetButtonDown("UICancel") && this.back != null)
		{
			this.back.SetActive(true);
			base.gameObject.SetActive(false);
		}
	}

	public UIController uc;

	public Selectable firstButton;

	public Selectable dummyButtonPC;

	public Selectable dummyButtonElse;

	public GameObject back;

	private Player player;
}
