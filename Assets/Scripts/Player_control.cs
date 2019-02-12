using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_control : MonoBehaviour {
	public float movementSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotLeftRight = Input.GetAxis("Mouse X");
		transform.Rotate(0, rotLeftRight, 0);

		float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

		Vector3 speed = new Vector3( sideSpeed, 0, forwardSpeed );
		CharacterController cc = GetComponent<CharacterController>();
		cc.SimpleMove( speed );
	}
}
