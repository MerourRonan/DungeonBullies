using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;
	public float m_TimeSpeed;
	public List<HeroActor> m_HeroActors;
	public List<MonsterActor> m_AllMonsterActors;
	public List<MonsterActor> m_BackMonsterActors;
	public List<MonsterActor> m_FrontMonsterActors;

	// Use this for initialization
	void Awake () {
		Instance = this;
		m_TimeSpeed = 1;
	}

	void Start () {
		SpawnManager.Instance.SpawnRaid ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddHero(HeroActor hero)
	{
		if(m_HeroActors == null)
		{
			m_HeroActors = new List<HeroActor> ();
		}
		m_HeroActors.Add (hero);
	}

	public void AddAllMonster(MonsterActor monster)
	{
		if(m_AllMonsterActors == null)
		{
			m_AllMonsterActors = new List<MonsterActor> ();
		}
		m_AllMonsterActors.Add (monster);
	}

	public void AddBackMonster(MonsterActor monster)
	{
		if(m_BackMonsterActors == null)
		{
			m_BackMonsterActors = new List<MonsterActor> ();
		}
		AddAllMonster (monster);
		m_BackMonsterActors.Add (monster);
	}

	public void AddFrontMonster(MonsterActor monster)
	{
		if(m_FrontMonsterActors == null)
		{
			m_FrontMonsterActors = new List<MonsterActor> ();
		}
		m_FrontMonsterActors.Add (monster);
		m_BackMonsterActors.Remove (monster);
	}
}
