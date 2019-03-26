using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public GameObject 	club;
	private float 		_speed = 0;
	private int 		_direction;
	private float 		_hole;
	private int 		_score;
	private bool 		count = false;

	void Start()
	{
		_hole = 3F;
		_direction = (_hole - transform.position.y < 0) ? 1 : -1;
		_score = -15;
		PutClub();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y >= _hole - 0.2F && transform.position.y <= _hole + 0.2F && _speed <= 0.7F)
		{
			_speed = 0;
			Debug.Log("Score: " + Mathf.Clamp(_score, -15, 0));
			Destroy(club);
			return;
		}
			
		if (Input.GetKey("space"))
		{
			_speed += 0.1F;
			_direction = (_hole - transform.position.y < 0) ? 1 : -1;
			count = true;
		}
		else
		{
			if (_speed > 0)
			{
				transform.Translate(new Vector3(0, _direction * (_speed + 1) * -0.1F, 0));
				_speed -= 0.1F;
				if (transform.position.y > 4.8F && _direction < 0)
					_direction = 1;
				if (transform.position.y < -4.8F && _direction > 0)
					_direction = -1;
			}
			else
			{
				if (count)
				{
					_score += 5;
					count = false;
				}
				Destroy(club);
				_direction = (_hole - transform.position.y < 0) ? 1 : -1;
				PutClub();
			}
		}
	}

	private void PutClub()
	{
		if (_direction < 0)
		{
			club = Instantiate(club, new Vector3(-0.15F, transform.position.y, 0), Quaternion.identity);
		}
		else
		{
			club = Instantiate(club, new Vector3(0.15F, transform.position.y + 0.9F, 0), Quaternion.identity);
			club.transform.localRotation  = Quaternion.Euler(0, 180, 0);
		}
	}
}
