using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehaviour : MonoBehaviour
{
	[Header("References")]
	public GameObject gemVisuals;
	public GameObject collectedParticleSystem;
	public GameObject _score;
	public CircleCollider2D gemCollider2D;
	public UI_Manager uiManager;

	private float durationOfCollectedParticleSystem;
// private float _score;

	void Start()
	{
		durationOfCollectedParticleSystem = collectedParticleSystem.GetComponent<ParticleSystem>().main.duration;

		GameObject.FindObjectsOfType<UI_Manager>();
	}

	void OnTriggerEnter2D(Collider2D theCollider)
	{
		if (theCollider.CompareTag ("Player")) {
			GemCollected ();
		}
	}

	void GemCollected()
	{
		gemCollider2D.enabled = false;
		gemVisuals.SetActive (false);
		collectedParticleSystem.SetActive (true);
		uiManager.AddScore();
		Invoke ("DeactivateGemGameObject", durationOfCollectedParticleSystem);
	}

	void DeactivateGemGameObject()
	{
		gameObject.SetActive (false);
	}
}
