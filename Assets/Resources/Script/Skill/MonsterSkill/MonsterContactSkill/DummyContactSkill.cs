using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyContactSkill : MonsterContactSkill {

	// Use this for initialization
	protected override void Awake () {
		base.Awake ();
		m_Damages = 1;
	}
}
