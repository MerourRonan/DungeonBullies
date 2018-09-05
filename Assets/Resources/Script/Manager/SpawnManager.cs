using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public static SpawnManager Instance;

	void Awake () {
		Instance = this;
	}
	
	public void SpawnRaid()
	{
		Transform heroParent = GameObject.Find ("Actors/Heroes").transform;
		int laneNumber = 0;
		foreach (string prefabname in GameInfo.Instance.m_RaidHeroes) {
			Vector3 spawnpos = LevelManager.Instance.m_Positions [laneNumber].transform.position;
			GameObject prefab = Resources.Load ("Prefab/Hero/" + prefabname) as GameObject;
			GameObject instance = Instantiate (prefab, spawnpos, Quaternion.identity) as GameObject;
			HeroActor script = instance.GetComponent<HeroActor> ();
			instance.transform.SetParent (heroParent);
			script.SetLaneNumber (laneNumber);
			LevelManager.Instance.m_Positions [laneNumber].m_HeroActor = script;
			laneNumber++;
		}

	}


}
