using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject	cube;
	private float		_spawnTime = 4;
	private float 		_timer = 4;
	private GameObject _instance;

    void Update () {
		if (_timer > _spawnTime)
		{
			if (Random.Range(0, 100) > 95 && !_instance)
			{
				_timer = 0;
				_instance = Instantiate(cube, cube.transform.localPosition, Quaternion.identity);
			}
		}
        _timer += Time.deltaTime;
	}
}
