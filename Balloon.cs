using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	public bool			inflate;
	public float		sizeBallon = 10;
	public int 			breath = 20;

	// Update is called once per frame
	void Update () {
		if (sizeBallon < 0 || sizeBallon > 100)
		{
			Debug.Log("Balloon life time: " + Mathf.RoundToInt(Time.time) + "s");
			Destroy(gameObject);
		}
		if (Input.GetKeyDown("space")) {
			inflate = true;
		}
		if (Input.GetKeyUp("space")) {
			inflate = false;
			print("space key was un pressed");
		}
		if (inflate && breath > 10) {
			transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
			sizeBallon += 1;
			breath -= 1;
		} else {
			transform.localScale -= new Vector3(0.01F, 0.01F, 0.01F);
			sizeBallon -= 0.1F;
			if (breath <= 20)
			{
				breath += 1;
			}
		}
	}
}
