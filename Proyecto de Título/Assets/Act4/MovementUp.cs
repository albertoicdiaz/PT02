﻿using UnityEngine;
using System.Collections;

public class MovementUp : MonoBehaviour {
public float speed;

    void Update() {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}