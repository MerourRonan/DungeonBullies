using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaidPosition : MonoBehaviour {

	public int m_Position;
	public HeroActor m_HeroActor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeHero(HeroActor hero)
	{
		m_HeroActor = hero;
		if (hero != null) {
			m_HeroActor.ChangeLane (m_Position);
		}
	}
}
