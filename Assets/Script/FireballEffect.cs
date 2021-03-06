﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class FireballEffect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Pipe")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
