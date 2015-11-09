using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	float x;
	float y;
	float z;
	public float velocidad;
	float auxVelocity;
	// Use this for initialization
	void Start () {
		x = GameObject.Find ("Player").transform.position.x;
		y = GameObject.Find ("Player").transform.position.y;
		z = GameObject.Find ("Player").transform.position.z;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			y += velocidad;
		if (Input.GetKey (KeyCode.S))
			y -= velocidad;
		if (Input.GetKey (KeyCode.A))
			x -= velocidad;
		if (Input.GetKey (KeyCode.D))
			x += velocidad;

		GameObject.Find ("Player").transform.position = (new Vector3 (x, y, z));


	}
}
