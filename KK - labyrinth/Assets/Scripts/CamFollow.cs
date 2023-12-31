﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        //follow the character with a y offset
        float camX = transform.position.x;
        float playerX = player.transform.position.x;
        float camY = transform.position.y;
        float playerY = player.transform.position.y;

        if ((Mathf.Abs(camX - playerX) > 0.5) || (Mathf.Abs(camY - playerY) > 0.5))
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 10.5f, player.transform.position.z);
        }
    }
}
