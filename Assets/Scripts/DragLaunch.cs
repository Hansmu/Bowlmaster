using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour {

	private Ball ball;
	private Vector3 dragStart;
	private float startTime;

	void Start () {
		ball = GetComponent<Ball>();
	}

	public void DragStart() {
		dragStart = Input.mousePosition;
		startTime = Time.time;
	}

	public void MoveStartPosition(float xMove) {
		if(!ball.IsInPlay()) {
			ball.transform.Translate(new Vector3(xMove, 0, 0));
		}
	}

	public void DragEnd() {
		float endTime = Time.time;
		Vector3 dragEnd = Input.mousePosition;

		float dragDuration = endTime - startTime;

		float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
		float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

		Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeedZ);
		ball.LaunchBall(launchVelocity);
	}
}
