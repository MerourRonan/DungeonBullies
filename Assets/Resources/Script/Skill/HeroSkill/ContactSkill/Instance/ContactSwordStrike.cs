using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactSwordStrike : ContactSkill {

	// Use this for initialization
	protected override void Awake () {
		base.Awake ();
		m_SkillReady = true;
		m_CooldownDuration = 1f;
		m_Damages = 5;
	}


}
