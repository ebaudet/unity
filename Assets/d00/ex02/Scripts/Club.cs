using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {

	private int 		_direction;
	private float 		_hole;
	
	void Start()
	{
		_hole = 3F;
		_direction = (_hole - transform.position.y < 0) ? 1 : -1;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space"))
		{
			if (_direction < 0)
				transform.Translate(Vector3.down);
			else
				transform.Translate(Vector3.up);
		}
	}
}
