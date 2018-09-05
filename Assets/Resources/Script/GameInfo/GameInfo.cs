using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour {

	public static GameInfo Instance;
	public List<string> m_RaidHeroes;

	// Use this for initialization
	void Awake () {
		Instance = this;
		m_RaidHeroes = new List<string> ();
		m_RaidHeroes.Add ("HeroDummyPrefab");
		m_RaidHeroes.Add ("HeroDummyPrefab");
	}

}
