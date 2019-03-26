using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public bool 	load = false;
	private float 	_speed = 0;
	private int 	direction;
	private float 	hole;

	void Start()
	{
		hole = 3F;
		direction = (hole - transform.position.y < 0) ? 1 : -1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		load |= Input.GetKeyDown("space");
		load &= !Input.GetKeyUp("space");

		if (load)
		{
			_speed += 0.1F;
			direction = (hole - transform.position.y < 0) ? 1 : -1;
		}

		if (!load && _speed > 0)
		{
			transform.Translate(new Vector3(0, direction * (_speed + 1) * -0.1F, 0));
			_speed -= 0.1F;
			if (transform.position.y > 4.8F && direction < 0)
				direction = 1;
			if (transform.position.y < -4.8F && direction > 0)
				direction = -1;
//			direction = (hole - transform.position.y < 0) ? 1 : -1;
//			move();
		}
	}

//	void move()
//	{
//		if (_speed > 0)
//		{
//			transform.Translate(new Vector3(0, direction * (_speed + 1) * -0.1F, 0));
//			direction = (hole - transform.position.y < 0) ? -1 : 1;
//			_speed -= 0.2F;
//		}
//	}
}
