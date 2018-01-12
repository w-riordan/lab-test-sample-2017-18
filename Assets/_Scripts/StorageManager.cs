﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageManager : MonoBehaviour {
	private StorageModel model;
	private StorageView view;
	private StorageController controller;

	public Text textUnits;
	public Text textNearFull;

	public InputField inputFieldDelivery;

	// Use this for initialization
	void Start () {
		// model
		model = new StorageModel();

		//view
		view = new StorageView();
		view.SetModel (model);
		view.SetUITexts (textUnits, textNearFull);
		view.Refresh ();

		// controller
		controller = new StorageController();
		controller.SetModel (model);
		controller.SetView (view);
		controller.SetInputFieldDelivery (inputFieldDelivery);
	}

	public void BUTTON_DeliveryOnClick(){
		controller.EVENT_Delivery ();
	}
}
