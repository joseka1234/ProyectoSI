using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public float speed = 0.03f;

	// Update is called once per frame
	void Update () {

		move (1, 0, speed);

	}

	public void move(int x, int y, float velocidad) {
		Vector3 aux = getPosition();
		aux.x += Vector3.right.x * (x * velocidad);
		aux.y += Vector3.up.y * (y * velocidad);
		setPosition (aux);
	}

	public void setPosition(Vector3 posicion){ 
		transform.position = posicion;
	}

	public Vector3 getPosition() {
		return transform.position;
	}
}
