using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour
{
	public string 			key;
	public bool 			isActive;
	private GameObject[] 	_players;
	
	// Use this for initialization
	void Start ()
	{
		_players = GameObject.FindGameObjectsWithTag("player");
	}
	
	// Update is called once per frame
	void Update () {
		SelectPlayer();
		
	}

	private void SelectPlayer()
	{
		if (Input.GetKeyDown(key))
		{
			foreach (GameObject _player in _players)
			{
				_player.GetComponent<playerScript_ex00>().isActive = false;
			}

			isActive = true;
		}
	}
}
