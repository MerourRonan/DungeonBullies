using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryRaidEffect : PrimarySkill {

	protected override IEnumerator SkillEffect()
	{
		GameManager.Instance.m_TimeSpeed = 0;
		foreach (HeroActor hero in GameManager.Instance.m_HeroActors) {
			ApplyEffect (hero);
			yield return new WaitForSeconds (0.3f);
		}
		GameManager.Instance.m_TimeSpeed = 1;
	}

	protected virtual void ApplyEffect(HeroActor hero)
	{

	}
}
