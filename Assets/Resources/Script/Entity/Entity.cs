using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

	public int m_HeartPoints;

	protected virtual void Awake () {
	}
		
	// Use this for initialization
	protected virtual void Start () {

	}

	// Update is called once per frame
	protected virtual void Update () {
	}

	public void ApplyDamage(int damages)
	{
		m_HeartPoints -= damages;
		if (m_HeartPoints <= 0) {
			Destroy (this.gameObject);
		}
	}
}
