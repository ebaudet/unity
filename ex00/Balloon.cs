using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	public bool			inflate;
	public float		sizeBallon = 10;
	public int 			breath = 100;

	// Update is called once per frame
	void Update () {
		if (sizeBallon < 0 || sizeBallon > 100)
		{
			Debug.Log("Balloon life time: " + Mathf.RoundToInt(Time.time) + "s");
			Destroy(gameObject);
            print("sizeBalloon : " + transform.localScale);
            print("normalize sizeBalloon : " + transform.localScale.normalized);
		}
        inflate |= Input.GetKeyDown("space");
        inflate &= !Input.GetKeyUp("space");
        if (inflate) {
			transform.localScale += new Vector3(0.1F, 0.1F, 0.1F) * ( breath / 100);
            sizeBallon += 1 * ( breath / 100);
            if (breath > 0)
				breath -= 1;
		} else {
			transform.localScale -= new Vector3(0.01F, 0.01F, 0.01F);
			sizeBallon -= 0.1F;
			if (breath <= 100)
			{
				breath += 10;
			}
		}
	}
}
