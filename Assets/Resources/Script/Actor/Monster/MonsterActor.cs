using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterActor : Actor {

	protected MonsterEntity m_MonsterEntity;
	public MonsterContactSkill m_ContactSkill;

	protected override void Awake()
	{
		base.Awake ();
	}
		
	protected override void Start()
	{
		base.Start ();

	}
	
	// Update is called once per frame
	void Update () {
		MonsterMove ();
	}


	public void MonsterMove()
	{
		m_Rigidbody.velocity = new Vector2 (-1, 0) * m_MonsterEntity.m_Speed*GameManager.Instance.m_TimeSpeed;
	}

	public void ActiveContactSkill(HeroActor hero)
	{
		m_ContactSkill.StartCoroutine (m_ContactSkill.ActiveContactSkill (hero));
	}

	void OnTriggerEnter2D(Collider2D currentCollider)
	{
		if (currentCollider.transform.tag == "BorderLeft") {
			Destroy (this.gameObject);
		}
		if (currentCollider.transform.tag == "RaidTrigger") {
			ContactManager.Instance.ContactTrigger (this);
		}
		if (currentCollider.transform.tag == "BackZone") {
			GameManager.Instance.AddBackMonster (this);
		}
		if (currentCollider.transform.tag == "FrontZone") {
			GameManager.Instance.AddFrontMonster (this);
		}
	}

	public void ApplyDamage(int damages)
	{
		m_MonsterEntity.ApplyDamage (damages);
	}

	public void SetMonsterEntity(MonsterEntity monster)
	{
		m_MonsterEntity = monster;
	}
	public void SetContactSkill(MonsterContactSkill skill)
	{
		m_ContactSkill = skill;
	}

}
