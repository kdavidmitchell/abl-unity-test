using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Speed of the player.
    private static float _speed = 5f;
    // Gravity.
	private static float _gravity = 20.0F;
	// Direction vector of movement.
	private Vector3 moveDirection = Vector3.zero;
    // Character controller script reference.
	public CharacterController controller;

	void Start(){
		// Store reference to attached controller.
		controller = GetComponent<CharacterController>();
	}

	void Update() 
	{
		// If character is on ground:
		if (controller.isGrounded) 
		{
			// Use input up and down for direction, multiplied by speed.
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= _speed;
		}
		// Apply gravity manually.
		moveDirection.y -= _gravity * Time.deltaTime;
		// Move using character controller, smoothing across frames.
		controller.Move(moveDirection * Time.deltaTime);
	}
}
