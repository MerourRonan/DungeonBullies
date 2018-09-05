using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterContactSkill : MonoBehaviour {

	protected int m_Damages;

	protected virtual void Awake () {

		transform.parent.GetComponent<MonsterActor> ().SetContactSkill (this);
	}

	// Use this for initialization
	protected virtual void Start () {

	}

	// Update is called once per frame
	protected virtual void Update () {

	}

	public IEnumerator ActiveContactSkill(HeroActor hero)
	{
		Debug.Log ("Monster Contact skill : applying damages");
		hero.ApplyDamage (m_Damages);
		yield return true;
	}
}
