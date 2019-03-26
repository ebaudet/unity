using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject	cube;
	public float		spawnTime;
	public float 		timer;


    void Update () {
		if (timer > spawnTime)
		{
			timer = 0;
            Instantiate(cube, cube.transform.localPosition, Quaternion.identity);
		}
        timer += Time.deltaTime;
	}
}
