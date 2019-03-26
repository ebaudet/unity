using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject	cube;
	public float		spawnTime;
	public float 		timer;
	// Update is called once per frame
	void Update () {
		if (timer > spawnTime)
		{
			timer = 0;
            Vector3 newPos = new Vector3(cube.transform.localPosition.x, cube.transform.localPosition.y, cube.transform.localPosition.z);
		}
	}
}
