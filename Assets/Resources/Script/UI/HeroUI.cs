using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroUI : MonoBehaviour {

	protected Text m_HeartPointsText;
	protected Slider m_PrimarySlide;
	protected Slider m_SecondarySlide;

	// Use this for initialization
	void Awake () {
		m_HeartPointsText = transform.Find ("HearLifeSprite/HeartPointsText").GetComponent<Text> ();
		m_PrimarySlide = transform.Find ("PrimarySlide").GetComponent<Slider> ();
		m_SecondarySlide = transform.Find ("SecondarySlide").GetComponent<Slider> ();
	}
	
	public void UpdateHeartPoints(int value)
	{
		m_HeartPointsText.text = value.ToString ();
	}

	public void UpdatePrimarySlide(float currentCooldown, float cooldownDuration)
	{
		float value = (cooldownDuration - currentCooldown) / cooldownDuration;
		m_PrimarySlide.value = value;
	}

	public void UpdateSecondarySlide(float currentCooldown, float cooldownDuration)
	{
		float value = (cooldownDuration - currentCooldown) / cooldownDuration;
		m_SecondarySlide.value = value;
	}
}
