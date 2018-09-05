using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryProjectile : SecondarySkill {

	public Transform m_SpawnPoint;
	public GameObject m_ProjectilePrefab;
	public int m_ProjectileDamage;
	public int m_nbProjectile;
	public float m_RateOfFire;



	protected override IEnumerator SkillEffect()
	{
		for (int iter = 0; iter < m_nbProjectile; iter++) {
			GameObject projInstance = Instantiate (m_ProjectilePrefab, m_SpawnPoint.position, Quaternion.identity);
			Projectile projScript = projInstance.GetComponent<Projectile> ();
			projScript.InitProjectile (m_Damages, "Monster");
			yield return new WaitForSeconds (m_RateOfFire);
		}
			
	}
}
