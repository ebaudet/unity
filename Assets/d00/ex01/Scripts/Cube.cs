using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	public string 		key;
	public CubeSpawner spawnerScript;
	
	private float 		_speed;
	private bool 		_willDie;

	private void Start() {
		_speed = Random.Range(0.5F, 1.5F);
		_willDie = false;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5)
			Destroy(gameObject);
		if (transform.position.y < -3) {
			Debug.Log("Object missed");
			spawnerScript.instances.Remove(gameObject);
		} else if (Input.GetKeyDown(key) && spawnerScript.instances.IndexOf(gameObject) == 0) {
			Debug.Log("Precision: " + (transform.position.y + 2));
			_willDie = true;
		}
		transform.Translate(new Vector3(0, _speed * -0.05F, 0));
	}

	void LateUpdate() {
		if (_willDie) {
			spawnerScript.instances.Remove(gameObject);
			Destroy(gameObject);
		}
	}
}
