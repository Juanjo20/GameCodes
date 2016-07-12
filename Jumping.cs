using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	// Use this for initialization


	public GameObject Ball;
	public float position_X;
	public float position_Y;
	public int Vel_Total;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vel_Total > 0) {
			return;
		} else {
			position_X += transform.position.x (Ball,position_X) as GameObject;
			position_Y += transform.position.y (Ball, position_Y) as GameObject;

		}
	}
}
