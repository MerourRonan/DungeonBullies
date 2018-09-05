﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimarySkill : Skill {

	protected override void Awake () {
		base.Awake ();
		transform.parent.GetComponent<HeroActor> ().SetPrimarySkill(this);
	}

	// Use this for initialization
	protected override void Start () {
		base.Start ();
	}

	// Update is called once per frame
	protected override void Update () {
		base.Update ();
	}

	public void ActivePrimarySkill()
	{
		if (m_SkillReady) {
			m_CurrentCooldown = m_CooldownDuration;
			m_SkillReady = false;
			StartCoroutine (SkillEffect ());
		}
	}

	protected virtual IEnumerator SkillEffect ()
	{
		yield return true;
	}
}
