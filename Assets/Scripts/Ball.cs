using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Rigidbody rigidBody;
	private AudioSource audioSource;
	private bool isInPlay = false;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LaunchBall(Vector3 launchVelocity) {
		if(!isInPlay) {
			audioSource = GetComponent<AudioSource>();
			audioSource.Play();

			rigidBody.useGravity = true;
			rigidBody.velocity = launchVelocity;

			isInPlay = true;
		}
	}

	public bool IsInPlay() {
		return isInPlay;
	}
}
