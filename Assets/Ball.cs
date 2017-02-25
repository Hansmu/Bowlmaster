using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Vector3 launchVelocity;

	private Rigidbody rigidBody;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.velocity = launchVelocity;
	
		LaunchBall();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LaunchBall() {
		audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}
}
