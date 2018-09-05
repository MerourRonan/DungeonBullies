using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public RaidPosition m_RaidPositionSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HeroSelection ();
		HeroSwap ();
		HeroActivePrimarySkill ();
	}

	protected void HeroSelection()
	{
		if (Input.GetMouseButtonUp (0)) {
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero,Mathf.Infinity,1<<LayerMask.NameToLayer("RaidPosition"));
			if (hit.collider != null && hit.collider.GetComponent<RaidPosition> ().m_HeroActor != null) {
				m_RaidPositionSelected = hit.collider.GetComponent<RaidPosition> ();
			} else {
				m_RaidPositionSelected = null;
			}
		}
	}
	protected void HeroSwap()
	{
		if (Input.GetMouseButtonUp (1) && m_RaidPositionSelected != null) {
			Debug.Log ("input 1");
			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero,Mathf.Infinity,1<<LayerMask.NameToLayer("RaidPosition"));
			if (hit.collider != null && hit.collider.GetComponent<RaidPosition>() != null) {
				Debug.Log ("position hit = " + hit.collider.transform.name);
				RaidPosition newRaidPosition = hit.collider.GetComponent<RaidPosition> ();
				if (newRaidPosition.m_HeroActor == null) {
					newRaidPosition.ChangeHero (m_RaidPositionSelected.m_HeroActor);
					m_RaidPositionSelected.ChangeHero (null);
				} else {
					HeroActor hero1 = m_RaidPositionSelected.m_HeroActor;
					HeroActor hero2 = newRaidPosition.m_HeroActor;
					newRaidPosition.ChangeHero (hero1);
					m_RaidPositionSelected.ChangeHero (hero2);
				}
				m_RaidPositionSelected = null;
			}
		}
	}
	protected void HeroActivePrimarySkill()
	{
		if (Input.GetKeyUp (KeyCode.Space) && m_RaidPositionSelected.m_HeroActor != null) {
			m_RaidPositionSelected.m_HeroActor.m_PrimarySkill.ActivePrimarySkill ();
		}
	}
}
