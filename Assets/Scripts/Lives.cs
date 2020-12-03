﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject.GetComponent<BoxCollider>());
        BoxCollider bc = gameObject.AddComponent<BoxCollider>();
        bc.size = new Vector3(2.2f, 0.5f, 2.0f);
        bc.isTrigger = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        FindObjectOfType<GameSession>().ProcessPlayerLives();
        Destroy(gameObject);
    }
}
