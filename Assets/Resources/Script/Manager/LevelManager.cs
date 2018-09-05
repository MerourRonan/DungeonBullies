using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public static LevelManager Instance;
	public RaidPosition[] m_Positions;

	// Use this for initialization
	void Awake () {
		Instance = this;
		initScript ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected void initScript()
	{
		m_Positions = new RaidPosition[4];
		m_Positions [0] = GameObject.Find ("Level/Raid/Position0").transform.GetComponent<RaidPosition>();
		m_Positions [1] = GameObject.Find ("Level/Raid/Position1").transform.GetComponent<RaidPosition>();
		m_Positions [2] = GameObject.Find ("Level/Raid/Position2").transform.GetComponent<RaidPosition>();
		m_Positions [3] = GameObject.Find ("Level/Raid/Position3").transform.GetComponent<RaidPosition>();
	}
}
