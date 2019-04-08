using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject	cube;
	public List<GameObject>  instances;
	
	private float		_spawnTime = 1;
	private float 		_timer = 4;

    void Update () {
		if (_timer > _spawnTime)
		{
			if (Random.Range(0, 100) > 95)
			{
				GameObject newCube;
				_timer = 0;
				newCube = Instantiate(cube, cube.transform.localPosition, Quaternion.identity);
				newCube.GetComponent<Cube>().spawnerScript = this;
				instances.Add(newCube);
			}
		}
        _timer += Time.deltaTime;
	}
}
