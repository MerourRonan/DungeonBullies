using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDummy : HeroEntity {

	protected override void Awake () {
		base.Awake ();
		m_HeartPoints = 10;
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
