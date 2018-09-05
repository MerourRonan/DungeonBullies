using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroActor : Actor {

	public HeroUI m_HeroUI;
	public HeroEntity m_HeroEntity;
	public PrimarySkill m_PrimarySkill;
	public SecondarySkill m_SecondarySkill;
	public ContactSkill m_ContactSkill;

	// Use this for initialization
	protected override void Awake () {
		base.Awake ();

	}

	protected override void Start()
	{
		base.Start ();
		GameManager.Instance.AddHero (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ActiveContactSkill(MonsterActor monster)
	{
		m_ContactSkill.StartCoroutine (m_ContactSkill.ActiveContactSkill (monster));
	}

	public void ApplyDamage(int damages)
	{
		m_HeroEntity.ApplyDamage (damages);
	}

	public void SetHeroEntity(HeroEntity hero)
	{
		m_HeroEntity = hero;
	}

	public void SetContactSkill(ContactSkill skill)
	{
		m_ContactSkill = skill;
	}
	public void SetSecondarySkill(SecondarySkill skill)
	{
		m_SecondarySkill = skill;
	}
	public void SetPrimarySkill(PrimarySkill skill)
	{
		m_PrimarySkill = skill;
	}

	public int GetLaneNumber()
	{
		return m_CurrentLaneNumbers[0];
	}


}
