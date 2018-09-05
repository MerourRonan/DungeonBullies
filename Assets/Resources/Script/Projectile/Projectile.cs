using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	protected Rigidbody2D m_Rigidbody;
	public string m_TargetType;
	public int m_Damages;
	public float m_Speed;


	protected virtual void Awake () {
		m_Rigidbody = transform.GetComponent<Rigidbody2D> ();
		m_Speed = 10;
	}
		
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InitProjectile(int damages, string targetType)
	{
		m_Damages = damages;
		m_TargetType = targetType;
		int direction = 0;
		if (targetType == "Hero") {
			direction = -1;
		} else {
			direction = 1;
		}
		ProjectileMove (direction);
	}

	public void ProjectileMove(int direction)
	{
		m_Rigidbody.velocity = new Vector2 (1, 0) * m_Speed*direction;
	}

	void OnTriggerEnter2D(Collider2D currentCollider)
	{
		if (currentCollider.transform.tag == "BorderLeft" || currentCollider.transform.tag == "BorderRight") {
			Destroy (this.gameObject);
		}
		else if (m_TargetType == "Hero" && currentCollider.transform.tag =="Hero") {
			currentCollider.transform.GetComponent<HeroActor> ().ApplyDamage (m_Damages);
			Destroy (this.gameObject);
		}
		else if (m_TargetType == "Monster" && currentCollider.transform.tag =="Monster") {
			Debug.Log ("collider name = " + currentCollider.transform.name);
			currentCollider.transform.GetComponent<MonsterActor> ().ApplyDamage (m_Damages);
			Destroy (this.gameObject);
		}
	}
}
