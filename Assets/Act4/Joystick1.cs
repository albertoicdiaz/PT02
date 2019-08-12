using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick1 : MonoBehaviour {
    public Transform player;
    public float speed = 5.0f;

	// Update is called once per frame
	void Update () 
    {
        moveCharacter (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
	}
	void moveCharacter(Vector2 direction){
        player.Translate(direction * speed * Time.deltaTime);
    }
}