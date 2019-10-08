﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyButton : MonoBehaviour {

	public float characterJump = 8f;

	void Update () {
		if(Input.GetMouseButtonDown(0)) // jump
		{
			GetComponent<Rigidbody2D>().velocity = new Vector3(0, characterJump, 0);

			transform.rotation = Quaternion.Euler(0, 0, 30f);

		}
		transform.Rotate(0, 0, -1f);
	}
}
