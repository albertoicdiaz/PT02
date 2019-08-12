using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour {

	Rigidbody2D rb;
	float dirX;
	public float speed = 20f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		dirX = Input.acceleration.x * speed;
		transform.position += new Vector3(Input.acceleration.x,0,0)*Time.deltaTime*speed;
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2 (dirX, 0f);
	}

}
