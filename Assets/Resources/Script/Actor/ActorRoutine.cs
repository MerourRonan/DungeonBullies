using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorRoutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator ChangeLane(int newLaneNumber)
	{
		Transform newLane = LevelManager.Instance.m_Positions [newLaneNumber].transform;
		Vector3 destination = transform.position;
		destination.y = newLane.position.y;
		while(this.transform.position.y != destination.y)
		{
			float step = 23 * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, destination, step);
			yield return new WaitForEndOfFrame ();
		}
	}
}
