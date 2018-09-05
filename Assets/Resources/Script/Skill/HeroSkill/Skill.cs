using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {

	public bool m_SkillReady;
	public float m_CooldownDuration;
	public float m_CurrentCooldown;
	public int m_Damages;

	protected virtual void Awake () {

	}


	// Use this for initialization
	protected virtual void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		UpdateCooldown ();
	}

	protected void UpdateCooldown()
	{

		m_CurrentCooldown -= Time.deltaTime*GameManager.Instance.m_TimeSpeed;
		if (m_CurrentCooldown <= 0) {
				m_SkillReady = true;
		}

	}
}
