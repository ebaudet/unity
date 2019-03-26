using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	public string 		key;
	public float 		speed;

	private void Start()
	{
		speed = Random.Range(0.5F, 1F);
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5)
			Destroy(gameObject);
		if (transform.position.y < -2) {
			Debug.Log("Object missed");
		} else if (Input.GetKeyDown(key)) {
			Debug.Log("Precision: " + (transform.position.y + 2));
			Destroy(gameObject);
		}
		transform.Translate(new Vector3(0, speed * -0.05F, 0));
	}
}
