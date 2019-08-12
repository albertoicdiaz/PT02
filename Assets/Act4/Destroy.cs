using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.name == "Trash")
        {
        Destroy(col.gameObject);
        }
    }
}
