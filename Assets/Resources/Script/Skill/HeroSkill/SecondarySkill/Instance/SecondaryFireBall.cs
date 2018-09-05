using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryFireBall : SecondaryProjectile {


	protected override void Awake () {
		base.Awake ();
		m_SpawnPoint = this.transform;
		m_ProjectilePrefab = Resources.Load ("Prefab/Projectile/DummyProjectilePrefab") as GameObject;
		m_ProjectileDamage = 2;
		m_nbProjectile = 3;
		m_RateOfFire = 0.2f;
		m_CooldownDuration =1;
	}


}
