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
			if (Random.Range(0, 100) > 95)
			{
				timer = 0;
				Instantiate(cube, cube.transform.localPosition, Quaternion.identity);
			}
//            tmp = Instantiate(cube, cube.transform.localPosition, Quaternion.identity);
//			tmp.speed = Random.Range(0.5F, 1F);
		}
        timer += Time.deltaTime;
	}
}
