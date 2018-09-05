using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryRaidEffect : SecondarySkill {

	protected override IEnumerator SkillEffect()
	{
		foreach (HeroActor hero in GameManager.Instance.m_HeroActors) {
			ApplyEffect (hero);
		}
		yield return true;
	}

	protected virtual void ApplyEffect(HeroActor hero)
	{
		
	}
}
