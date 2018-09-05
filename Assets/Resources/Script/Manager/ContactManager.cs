using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactManager : MonoBehaviour {

	public static ContactManager Instance;

	// Use this for initialization
	void Awake () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ContactTrigger(MonsterActor monster)
	{
		List<HeroActor> heroes = new List<HeroActor> ();
		foreach (int laneNumber in monster.m_CurrentLaneNumbers) {
			foreach (HeroActor hero in GameManager.Instance.m_HeroActors) {
				if (hero.GetLaneNumber() == laneNumber) {
					heroes.Add (hero);
				}
			}
		}
		StartCoroutine (ContactTriggerRoutine (monster, heroes));
	}

	protected IEnumerator ContactTriggerRoutine(MonsterActor monster, List<HeroActor> heroes)
	{
		foreach (HeroActor hero in heroes) {
			hero.ActiveContactSkill (monster);
			yield return new WaitForSeconds (0.3f);
		}
		foreach (HeroActor hero in heroes) {
			monster.ActiveContactSkill (hero);
		}
	}
}
