using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {

	protected ActorRoutine m_ActorRoutine;
	protected Rigidbody2D m_Rigidbody;
	public List<int> m_CurrentLaneNumbers;

	// Use this for initialization
	protected virtual void Awake () {
		m_ActorRoutine = transform.GetComponent<ActorRoutine> ();
		m_Rigidbody = transform.GetComponent<Rigidbody2D> ();
		m_CurrentLaneNumbers = new List<int> ();
		m_CurrentLaneNumbers.Add (0);
	}

	// Use this for initialization
	protected virtual void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public virtual void ChangeLane(int newLaneNumber)
	{
		SetLaneNumber (newLaneNumber);
		StartCoroutine(m_ActorRoutine.ChangeLane(newLaneNumber));
	}

	public virtual void SetLaneNumber(int number)
	{
		if (m_CurrentLaneNumbers == null) {
			m_CurrentLaneNumbers = new List<int> ();
		}
		m_CurrentLaneNumbers.Clear ();
		m_CurrentLaneNumbers.Add (number);

	}


}
