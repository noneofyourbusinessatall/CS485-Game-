using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_control : MonoBehaviour {
	public bool cursor_check = true;
	public float speed = 6.0F;
	public float gravity = 20.0F;

	private Vector3 moveDirection = Vector3.zero;
	public CharacterController controller;

	void Start() {
	// Store reference to attached component
		controller = GetComponent<CharacterController>();
	}

	void Update() {
		if(Input.GetKey(KeyCode.Escape)) {
				cursor_check = false;
			}
			if(Input.GetKey(KeyCode.Space)) {
				cursor_check = true;
			}
			if (cursor_check) {
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
			else {
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
	// Character is on ground (built-in functionality of Character Controller)
	if (controller.isGrounded) {
			if(Input.GetKey(KeyCode.Escape)) {
				cursor_check = false;
			}
			if(Input.GetKey(KeyCode.Space)) {
				cursor_check = true;
			}
			if (cursor_check) {
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
			else {
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
			float rotLeftRight = Input.GetAxis("Mouse X");
			transform.Rotate(0, rotLeftRight, 0);
	// Use input up and down for direction, multiplied by speed
	moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	moveDirection = Camera.main.transform.TransformDirection(moveDirection);
	moveDirection *= speed;

	}
	// Apply gravity manually.
	moveDirection.y -= gravity * Time.deltaTime;
	// Move Character Controller
		controller.Move(moveDirection * Time.deltaTime);
		}
	}