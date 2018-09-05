using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDummy : MonsterEntity {

	protected override void Awake () {
		base.Awake();
		m_HeartPoints = 10;
		m_Speed = 2f;
	}

	// Use this for initialization
	protected override void Start () {
		base.Start();

	}

	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}
}
