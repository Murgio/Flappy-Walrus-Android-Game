﻿using UnityEngine;
using System.Collections;

/**
 * Created by Muriz on 14.02.14 
 */

public class GroundMover : MonoBehaviour {

	Rigidbody2D player;

	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		
		if(player_go == null) {
			Debug.LogError("Couldn't find an object with tag 'Player'!");
			return;
		}
		
		player = player_go.GetComponent<Rigidbody2D>();
		
	}

	void FixedUpdate() {
		float vel = player.velocity.x * 0.75f;

		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
	}
}
