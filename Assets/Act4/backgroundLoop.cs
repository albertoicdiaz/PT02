using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundLoop : MonoBehaviour
{
    [SerializeField]
    private Transform centerBackground;

    void Update ()
    {
        if (transform.position.y >= centerBackground.position.y+ 5)
            centerBackground.position = new Vector2(centerBackground.position.x, transform.position.y + 5f);
        else if (transform.position.y <= centerBackground.position.y - -5f)
            centerBackground.position = new Vector2 (centerBackground.position.x, transform.position.y - -5f);
    }
}