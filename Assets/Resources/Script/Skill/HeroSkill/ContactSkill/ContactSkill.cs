using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactSkill : Skill {

	protected override void Awake () {
		base.Awake ();
		transform.parent.GetComponent<HeroActor> ().SetContactSkill (this);
	}

	// Use this for initialization
	protected override void Start () {
		base.Start ();
	}

	// Update is called once per frame
	protected override void Update () {
		base.Update ();
	}

	public IEnumerator ActiveContactSkill(MonsterActor monster)
	{
		if (m_SkillReady) {
			Debug.Log ("Contact skill : applying damages");
			monster.ApplyDamage (m_Damages);
			yield return new WaitForSeconds (0.5f);
			m_CurrentCooldown = m_CooldownDuration;
		}
	}
}
