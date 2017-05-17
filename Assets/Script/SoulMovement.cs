using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulMovement : MonoBehaviour {

	public float speed;
	public Vector3 MovingTargetOrigin;
	float range;
	// Use this for initialization
	void Start () {
		MovingTargetOrigin = transform.position;
		range = Random.Range (2, 5);
	}

	// Update is called once per frame
	void Update () {
		speed += 1.0f;
		transform.position = MovingTargetOrigin + new Vector3 (Mathf.Sin (Time.time * range), 0, 0);
	}
}