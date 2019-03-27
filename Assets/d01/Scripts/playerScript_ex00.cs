using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour
{
	public string 			key;
	public bool 			isActive;
	public float 			speed;
	public float 			jump;
	private GameObject[] 	_players;
	private Camera 			_mainCamera;

	// Use this for initialization
	void Start ()
	{
		_players = GameObject.FindGameObjectsWithTag("Player");
		_mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		SelectPlayer();
	}

	void FixedUpdate()
	{
		if (isActive)
		{
			_mainCamera.transform.position = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.5F, -10);
			MovePlayer();
		}
	}

	private void SelectPlayer()
	{
		if (Input.GetKeyDown(key) || Input.GetKeyDown("["+key+"]"))
		{
			foreach (GameObject player in _players)
			{
				player.GetComponent<playerScript_ex00>().isActive = false;
			}

			isActive = true;
			Debug.Log("player "+key+" is active");
		}
	}

	private void MovePlayer()
	{
		if (Input.GetKey("left"))
		{
			Debug.Log("move left");
			GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed * Time.deltaTime);
//			GetComponent<Rigidbody2D>().transform.Translate(Vector3.left * Time.deltaTime);
//			GetComponent<Rigidbody2D>().transform.tag(GetComponent<Rigidbody2D>().position + Vector2.left * Time.deltaTime * 5F);
//			transform.positioven += new Vector3(-1, 0, 0) * Time.deltaTime;

		}
		if (Input.GetKey("right"))
		{
			Debug.Log("move rignt");
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
		}
		if (Input.GetKey("up") || Input.GetKey("space"))
		{
			Debug.Log("move up");
//			ContactPoint2D[] contacts = new ContactPoint2D[10];
//			GetComponent<Rigidbody2D>().GetContacts(contacts);
//			foreach (ContactPoint2D contact in contacts)
//			{
//				Debug.Log("contact pos("+contact.point.x + ", " + contact.point.y + ")");
//			}
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10 * jump);
//			GetComponent<Rigidbody2D>().transform.Translate(Vector3.up * Time.deltaTime);
		}
	}
}
