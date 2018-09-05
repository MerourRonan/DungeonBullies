using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryZoneEffect : SecondarySkill {

	protected List<string> m_Zones;
	protected List<int> m_Lanes;

	protected override IEnumerator SkillEffect()
	{
		List<MonsterActor> monsters = new List<MonsterActor> ();
		foreach (string zone in m_Zones) {
			
			if (zone == "BackZone") {
				monsters = GameManager.Instance.m_BackMonsterActors;
			}
			if (zone == "FrontZone") {
				monsters = GameManager.Instance.m_FrontMonsterActors;
			}
			foreach (MonsterActor monster in monsters) {
				foreach (int lane in m_Lanes) {
					if (monster.m_CurrentLaneNumbers[0] == lane) {
						ApplyEffect (monster);
					}
				}
			}
		}
		yield return true;
	}

	protected virtual void ApplyEffect(MonsterActor monster)
	{
		monster.ApplyDamage (m_Damages);
	}
}
