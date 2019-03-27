using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	public string 		key;
	private float 		_speed;

	private void Start()
	{
		_speed = Random.Range(0.5F, 1.5F);
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5)
			Destroy(gameObject);
		if (transform.position.y < -3) {
			Debug.Log("Object missed");
		} else if (Input.GetKeyDown(key)) {
			Debug.Log("Precision: " + (transform.position.y + 2));
			Destroy(gameObject);
		}
		transform.Translate(new Vector3(0, _speed * -0.05F, 0));
	}
}
