﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroEntity : Entity {

	protected override void Awake () {
		base.Awake ();
		transform.GetComponent<HeroActor> ().SetHeroEntity (this);
	}

	// Use this for initialization
	protected override void Start () {
		base.Start ();

	}

	// Update is called once per frame
	protected override void Update () {
		base.Update ();
	}
}
