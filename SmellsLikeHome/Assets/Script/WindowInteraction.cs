﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowInteraction : MonoBehaviour
{
    public bool WindowOpen;
    public bool canClose;
    public Vector3 translationDoor;
    public Transform Window;

    public Transform player;
    public Transform PlayerCam;

    private bool hasPlayer = false;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        WindowOpen = false;
        canClose = false;
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
            WindowOpen = false;
            translationDoor = new Vector3(0, -1f * Time.deltaTime, 0);
        }

        if (WindowOpen && !canClose)
        {
            translationDoor = new Vector3(0, 1f * Time.deltaTime, 0);
        }
        Window.transform.Translate(translationDoor);
    }

    
}
