﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public bool DoorOpen;
    public bool canClose;
    public Vector3 rotationDoor;
    public Transform Door;

    public Transform player;
    public Transform PlayerCam;

    private bool hasPlayer = false;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        DoorOpen = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 4f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        if (hasPlayer && Input.GetMouseButtonDown(0) && canClose)
        {
            DoorOpen = false;
            rotationDoor = new Vector3(0f, -90f * Time.deltaTime, 0f);
        }

        if (DoorOpen && !canClose)
        {
            rotationDoor = new Vector3(0f, 90f * Time.deltaTime, 0f);
        }
        Door.transform.parent.Rotate(rotationDoor);
    }
}

