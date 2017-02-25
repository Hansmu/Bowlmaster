using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Ball ball;

	private Vector3 offsetBetweenCameraAndBall;
	private const int HEADPIN_LOCATION = 1829;

	// Use this for initialization
	void Start () {
		offsetBetweenCameraAndBall = transform.position - ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.z <= HEADPIN_LOCATION) {
			transform.position = ball.transform.position + offsetBetweenCameraAndBall;
		}
	}
}
