using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	protected GameObject m_HeroUIPrefab;
	protected Transform m_RaidUIParent;


	// Use this for initialization
	void Awake () {
		m_HeroUIPrefab = Resources.Load ("Prefab/UI/HeroUI") as GameObject;
		m_RaidUIParent = GameObject.Find ("Canvas/RaidUI").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnHeroUI(HeroActor heroScript)
	{
		GameObject instance = Instantiate (m_HeroUIPrefab, Vector3.zero, Quaternion.identity) as GameObject;
		insta

	}
}
