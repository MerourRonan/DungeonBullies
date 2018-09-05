using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryBlizzard : PrimaryZoneEffect {

	protected override void Awake () {
		base.Awake ();
		m_Lanes = new List<int> ();
		m_Zones = new List<string> ();
		m_Lanes.Add (0);
		m_Lanes.Add (1);
		m_Lanes.Add (2);
		m_Lanes.Add (3);
		m_Zones.Add ("BackZone");
		m_CooldownDuration = 5;
		m_Damages = 5;
	}
	

}
