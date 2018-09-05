using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryZoneEffect : PrimarySkill {

	protected List<string> m_Zones;
	protected List<int> m_Lanes;

	protected override IEnumerator SkillEffect()
	{
		GameManager.Instance.m_TimeSpeed = 0;
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
						yield return new WaitForSeconds (0.3f);
					}
				}
			}
		}
		GameManager.Instance.m_TimeSpeed = 1;
	}

	protected virtual void ApplyEffect(MonsterActor monster)
	{
		monster.ApplyDamage (m_Damages);
	}
}
